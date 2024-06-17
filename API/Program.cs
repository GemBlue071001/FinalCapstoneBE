using Application;
using Application.Interface;
using Application.MyMapper;
using Application.Services;
using Domain;
using Infrastructure;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

using Swashbuckle.AspNetCore.Filters;
using System.Text;


var builder = WebApplication.CreateBuilder(args);


var configuration = builder.Configuration.Get<AppSettings>();
builder.Services.AddControllers();
//config api 
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql(configuration!.ConnectionStrings.DefaultConnection);
    options.ConfigureWarnings(warnings =>
            warnings.Ignore(CoreEventId.NavigationBaseIncludeIgnored));
});

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
    });

builder.Services.AddAutoMapper(typeof(MapperConfigurationsProfile).Assembly);
builder.Services.AddSignalR();


builder.Services.AddSingleton(configuration!);
builder.Services.AddScoped<IClaimsService, ClaimsService>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IJobService, JobService>();
builder.Services.AddScoped<ICampaignService, CampaignService>();
builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddScoped<ICandidateService, CandidateService>();
builder.Services.AddScoped<ITrainingProgramService, TrainingProgramService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IAssessmentService, AssessmentService>();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
app.UseSwaggerUI();
//}
app.UseCors(p => p.SetIsOriginAllowed(origin => true).AllowAnyHeader().AllowAnyMethod().AllowCredentials());
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapHub<SignalrHub>("/communication");

app.Run();
