namespace AltShiftWorker {
    public class Worker : BackgroundService {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger) {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken) {

            var textReader = new TextReader();

            while (!stoppingToken.IsCancellationRequested) {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                var input = textReader.GetSelectedText();
                Console.WriteLine($"Iam here {input}");
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}