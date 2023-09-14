using System.Globalization;

namespace Toaster
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var config = Config.Load();

            if (config.ToastTitle == null || config.ToastTitle.Length == 0)
            {
                var lang = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;
                var title = Languages.GetToastTitle(lang);
                if (title == null)
                {
                    var dialogResult = MessageBox.Show(
                        $"Automatic configuration of the notification title is not supporet for {lang} yet!\n\n" +
                        "For more information and for a way to fix this see the project's README.",
                        "Toaster - Unsupported Language",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                config.ToastTitle = title;
                config.Save();
            }

            var tokenSource = StartToasting(config);

            ApplicationConfiguration.Initialize();
            Application.Run(new ConfigForm(config,
                onSave: (newConfig) =>
                {
                    config = newConfig;
                    config.Save();
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