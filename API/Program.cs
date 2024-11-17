using API.Middleware;
using API.Validation.Authenticaction;
using Application;
using Application.Interface;
using Application.MyMapper;
using Application.Services;
using Application.SignalRHub.Model;
using Application.Worker;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using Domain;
using FluentValidation;
using FluentValidation.AspNetCore;
using Hangfire;
using Hangfire.PostgreSql;
using Infrastructure;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

using Swashbuckle.AspNetCore.Filters;
using System.Text;


var builder = WebApplication.CreateBuilder(args);


var configuration = builder.Configuration.Get<AppSettings>();
builder.Services.Configure<AppSettings>(builder.Configuration);
builder.Services.AddControllers();
builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});
builder.Services.AddFluentValidationAutoValidation();


//config api 
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql(configuration!.ConnectionStrings.LocalDockerConnection);
    //options.UseNpgsql(configuration!.ConnectionStrings.LocalDockerConnection);
    options.ConfigureWarnings(warnings =>
            warnings.Ignore(CoreEventId.NavigationBaseIncludeIgnored));
});

//builder.Services.AddHangfire(config => config.UsePostgreSqlStorage(options => options.UseNpgsqlConnection(configuration!.ConnectionStrings.LocalDockerConnection)));
builder.Services.AddHangfire(config => config.UsePostgreSqlStorage(options => options.UseNpgsqlConnection(configuration!.ConnectionStrings.LocalDockerConnection)));



builder.Services.AddHangfireServer();

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

builder.Services.AddSwaggerGen
    (
    opt =>
    {
        opt.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
        {
            Description = "Standard Authorization (\"bearer {token}\" ) ",
            In = ParameterLocation.Header,
            Name = "Authorization",
            Type = SecuritySchemeType.ApiKey
        });
        opt.OperationFilter<SecurityRequirementsOperationFilter>();

    }

    );
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(opt =>
    {
        opt.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration!.SecretToken.Value)),
            ValidateIssuer = false,
            ValidateAudience = false,
        };

        opt.Events = new JwtBearerEvents
        {
            OnMessageReceived = context =>
            {
                var accessToken = context.Request.Query["access_token"];
                if (!string.IsNullOrEmpty(accessToken) &&
                    context.HttpContext.Request.Path.StartsWithSegments("/signalrHub"))
                {
                    context.Token = accessToken;
                }
                return Task.CompletedTask;
            }
        };
    });

builder.Services.AddAutoMapper(typeof(MapperConfigurationsProfile).Assembly);
builder.Services.AddSignalR(e => {
    e.MaximumReceiveMessageSize = 102400000;
});

builder.Services.AddSingleton<IDictionary<string, UserConnection>>(opts => new Dictionary<string, UserConnection>());

builder.Services.AddSingleton<IUserIdProvider, CustomUserIdProvider>();

builder.Services.AddSingleton(configuration!);
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IClaimService, ClaimService>();
builder.Services.AddScoped<IJobPostService, JobPostService>();
builder.Services.AddScoped<IJobLocationService, JobLocationService>();
builder.Services.AddScoped<IJobTypeService, JobTypeServcie>();
builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<IEducationDetailsService, EducationDetailsService>();
builder.Services.AddScoped<IExperienceDetailService, ExperienceDetailService>();
builder.Services.AddScoped<ISkillSetService, SkillSetService>();
builder.Services.AddScoped<IJobPostActivityService, JobPostActivityService>();
builder.Services.AddScoped<IBusinessStreamService, BusinessStreamService>();
builder.Services.AddScoped<ICVService, CVService>();
builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddScoped<IFollowCompanyService, FollowCompanyService>();
builder.Services.AddScoped<IEventTriggerService, EventTriggerService>();
builder.Services.AddScoped<IFollowJobPostService, FollowJobPostService>();
builder.Services.AddScoped<IJobPostActivityCommentService, JobPostActivityCommentService>();
builder.Services.AddScoped<IFileHandlingService, FileHandlingService>();
builder.Services.AddScoped<IVnPayService, VnPayService>();
builder.Services.AddScoped<ISubscriptionService, SubscriptionService>();
builder.Services.AddScoped<IUserJobAlertCriteriaService, UserJobAlertCriteriaService>();
builder.Services.AddHostedService<JobAlertWorker>();


builder.Services.AddValidatorsFromAssemblyContaining<RegisterValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<ChangePasswordValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<NewEmailValidator>();
builder.Services.AddValidatorsFromAssemblyContaining<CompanyRegisterRequestValidator>();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//using (var scope = app.Services.CreateScope())
//{
//    var recurringJobManager = scope.ServiceProvider.GetRequiredService<IRecurringJobManager>();
//    recurringJobManager.AddOrUpdate<IUserJobAlertCriteriaService>(
//        "fetch-matching-jobs",
//        job => job.ProcessMatchingJob(),
//        //job => job.SendValidationEmail("trinhtam2001@gmail.com", "hello job"),
//        "*/10 * * * * *" // Runs every 10 seconds
//    );
//}



app.UseSwagger();
app.UseSwaggerUI();

app.UseCors(p => p.SetIsOriginAllowed(origin => true).AllowAnyHeader().AllowAnyMethod().AllowCredentials());
app.UseMiddleware<ValidationMiddleware>();
app.UseMiddleware<ExceptionMiddleware>();
app.UseHangfireDashboard("/dashboard");

app.UseHttpsRedirection();

app.MapHub<SignalrHub>("/signalrHub");

app.UseAuthorization();

app.MapControllers();



//using (var serviceScope = app.Services.GetRequiredService<IServiceScopeFactory>().CreateScope())
//{
//    serviceScope.ServiceProvider.GetService<AppDbContext>().Database.Migrate();
//}

app.Run();
