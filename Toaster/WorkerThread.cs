using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Toaster
{

    internal class WorkerThread
    {
        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        [DllImport("user32.dll")]
        private static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        private const short SWP_NOSIZE = 0x1;
        private const short SWP_NOZORDER = 0x4;
        private const int SWP_SHOWWINDOW = 0x0040;

        [DllImport("user32.dll")]
        private static extern IntPtr SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);

        private const string TopLeft = "Top Left";
        private const string TopRight = "Top Right";
        private const string BottomLeft = "Bottom Left";
        private const string BottomRight = "Bottom Right";

        private readonly Config config;
        private readonly CancellationToken token;

        public WorkerThread(Config config, CancellationToken token)
        {
            this.config = config;
            this.token = token;
        }

        public void Run()
        {
            // You might be wondering why this program's backbone is an infinite loop. Couldn't I have used some sort of callback mechanism?
            // Ask the Kernel to notify the process a toast pops up?
            // I tried that. I've tried SetWindowHookEx from the Win32 API, I've also tried NotificationListener from UWP (?). It's simply
            // been a nerve-wracking experience. Whatever I tried it always felt like VS and Windows were throwing rocks in my way.
            // If you are more experienced with Windows than I am (I'm mostly a Linux user) then feel free to implement this in a callback
            // fashion.
            while (!token.IsCancellationRequested)
            {
                Tick();
                Thread.Sleep(config.Timeout);
            }
        }

        private void Tick()
        {
            var hWnd = FindWindow("Windows.UI.Core.CoreWindow", config.ToastTitle);
            if (hWnd == IntPtr.Zero)
            {
                return;
            }

            GetWindowRect(hWnd, out RECT rect);
            var screen = Screen.PrimaryScreen.Bounds;

            switch (config.Corner)
            {
                case TopLeft:
                    MoveWindow(hWnd, 0, 0);
                    break;
                case TopRight:
                    MoveWindow(hWnd, screen.Width - (rect.Right - rect.Left), 0);
                    break;
                case BottomLeft:
                    MoveWindow(hWnd, 0, screen.Height - (rect.Bottom - rect.Top));
                    break;
                case BottomRight:
                    // It's already in the bottom right by default...
                    break;
            }
        }

        private void MoveWindow(IntPtr hWnd, int x, int y)
        {
            SetWindowPos(hWnd, IntPtr.Zero, x + config.OffsetX, y + config.OffsetY, 0, 0, SWP_NOSIZE | SWP_NOZORDER | SWP_SHOWWINDOW);
        }

    }
}
