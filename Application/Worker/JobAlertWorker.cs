using Application.Interface;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Application.Worker
{
    public class JobAlertWorker : BackgroundService
    {
        private readonly IServiceProvider _serviceProvider;

        public JobAlertWorker(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                using (var scope = _serviceProvider.CreateScope())
                {
                    var userJobAlertService = scope.ServiceProvider.GetRequiredService<IUserJobAlertCriteriaService>();

                    try
                    {
                        // Call your method to process matching jobs
                        await userJobAlertService.ProcessMatchingJob();
                    }
                    catch (Exception ex)
                    {
                        // Log or handle exception as needed
                        Console.WriteLine($"Error in background job: {ex.Message}");
                    }
                }

                // Delay for the desired interval (e.g., 10 seconds)
                await Task.Delay(TimeSpan.FromSeconds(10), stoppingToken);
            }
        }
    }
}
