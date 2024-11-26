using Application.Interface;
using Application.Queues;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Application.Worker
{
    public class EmailWorker : BackgroundService
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ILogger<EmailWorker> _logger;

        public EmailWorker(IServiceProvider serviceProvider, ILogger<EmailWorker> logger)
        {
            _serviceProvider = serviceProvider;
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    // Dequeue the job from a shared queue or process tasks
                    var emailJob = EmailJobQueue.Dequeue(); // Implement a queue like ConcurrentQueue
                    if (emailJob != null)
                    {
                        using var scope = _serviceProvider.CreateScope();
                        var emailService = scope.ServiceProvider.GetRequiredService<IEmailService>();
                        var unitOfWork = scope.ServiceProvider.GetRequiredService<IUnitOfWork>();

                        await emailJob(emailService, unitOfWork); // Execute the email sending job
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError($"Error processing email job: {ex.Message}");
                }

                await Task.Delay(1000, stoppingToken); // Adjust delay as needed
            }
        }
    }

}
