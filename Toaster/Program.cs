namespace Toaster
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // TODO: Try setting ToastTitle based on locale setting.
            var config = new Config()
            {
                ToastTitle = "New Notification",
                Corner = "Top Left",
            };
            var tokenSource = StartToasting(config);

            ApplicationConfiguration.Initialize();
            Application.Run(new ConfigForm(config,
                onSave: (newConfig) =>
                {
                    config = newConfig;
                    tokenSource.Cancel();
                    tokenSource = StartToasting(config);
                },
                onStop: () =>
                {
                    tokenSource.Cancel();
                    Application.Exit();
                }
            ));
        }

        private static CancellationTokenSource StartToasting(Config config)
        {
            var tokenSource = new CancellationTokenSource();
            new Thread(new WorkerThread(config, tokenSource.Token).Run).Start();
            return tokenSource;
        }

    }
}