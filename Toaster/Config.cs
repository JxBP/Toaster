namespace Toaster
{
    public class Config
    {
        public string ToastTitle { get; set; }

        public int Timeout { get; set; } = 100;

        // Yes I wanted this to be an enum as much as the next guy but then I would have
        // to parse it from a string in the Form anyway ...
        public string Corner { get; set; }

        public int OffsetX { get; set; } = 0;

        public int OffsetY { get; set; } = 0;

        public void Save()
        {
            Properties.Settings.Default.ToastTitle = ToastTitle;
            Properties.Settings.Default.Timeout = Timeout;
            Properties.Settings.Default.Corner = Corner;
            Properties.Settings.Default.OffsetX = OffsetX;
            Properties.Settings.Default.OffsetY = OffsetY;
            Properties.Settings.Default.Save();
        }

        public static Config Load()
        {
            var config = new Config()
            {
                ToastTitle = Properties.Settings.Default.ToastTitle,
                Timeout = Properties.Settings.Default.Timeout,
                Corner = Properties.Settings.Default.Corner,
                OffsetX = Properties.Settings.Default.OffsetX,
                OffsetY = Properties.Settings.Default.OffsetY,
            };
            return config;
        }

    }
}
