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
    }
}
