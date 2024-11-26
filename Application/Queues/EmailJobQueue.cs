using Application.Interface;
using System.Collections.Concurrent;

namespace Application.Queues
{
    public static class EmailJobQueue
    {
        private static readonly ConcurrentQueue<Func<IEmailService, IUnitOfWork, Task>> _queue = new();

        public static void Enqueue(Func<IEmailService, IUnitOfWork, Task> job)
        {
            _queue.Enqueue(job);
        }

        public static Func<IEmailService, IUnitOfWork, Task>? Dequeue()
        {
            _queue.TryDequeue(out var job);
            return job;
        }
    }
}
