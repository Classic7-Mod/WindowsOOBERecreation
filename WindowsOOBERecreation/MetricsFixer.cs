using System;
using System.Runtime.InteropServices;
using System.Text;

namespace WindowsOOBERecreation
{
    class MetricsFixer
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct LOGFONT
        {
            public int lfHeight;
            public int lfWidth;
            public int lfEscapement;
            public int lfOrientation;
            public int lfWeight;
            public byte lfItalic;
            public byte lfUnderline;
            public byte lfStrikeOut;
            public byte lfCharSet;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string lfFaceName;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct NONCLIENTMETRICS
        {
            public uint cbSize;
            public LOGFONT lfMessageFont;
            public LOGFONT lfCaptionFont;
            public LOGFONT lfMenuFont;
            public LOGFONT lfSmCaptionFont;
            public LOGFONT lfStatusFont;
            public int iBorderWidth;
            public int iScrollWidth;
            public int iScrollHeight;
            public int iCaptionWidth;
            public int iCaptionHeight;
            public int iSmCaptionWidth;
            public int iSmCaptionHeight;
            public int iMenuWidth;
            public int iMenuHeight;
            public int iMenuButtonWidth;
            public int iMenuButtonHeight;
        }

        const uint SPI_GETNONCLIENTMETRICS = 41;
        const uint SPI_SETNONCLIENTMETRICS = 42;
        const uint SPIF_UPDATEINIFILE = 0x1;
        const uint SPIF_SENDCHANGE = 0x2;
        const int WM_SETTINGCHANGE = 0x001A;

        public static readonly IntPtr HWND_BROADCAST = new IntPtr(0xFFFF);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern bool SystemParametersInfoW(uint uiAction, uint uiParam, ref NONCLIENTMETRICS pvParam, uint fWinIni);

        [DllImport("user32.dll")]
        public static extern bool PostMessage(IntPtr hwnd, uint msg, uint wParam, IntPtr lParam);

        public static void FixMetrics()
        {
            NONCLIENTMETRICS metrics = new NONCLIENTMETRICS();
            metrics.cbSize = (uint)Marshal.SizeOf(typeof(NONCLIENTMETRICS));

            if (SystemParametersInfoW(SPI_GETNONCLIENTMETRICS, metrics.cbSize, ref metrics, 0))
            {
                LOGFONT sgFont = new LOGFONT
                {
                    lfHeight = -12,
                    lfWeight = 400,
                    lfCharSet = 1,
                    lfFaceName = "Segoe UI"
                };

                metrics.lfMessageFont = sgFont;
                metrics.lfCaptionFont = sgFont;
                metrics.lfMenuFont = sgFont;
                metrics.lfSmCaptionFont = sgFont;
                metrics.lfStatusFont = sgFont;

                if (SystemParametersInfoW(SPI_SETNONCLIENTMETRICS, metrics.cbSize, ref metrics, SPIF_UPDATEINIFILE | SPIF_SENDCHANGE))
                {
                    PostMessage(HWND_BROADCAST, WM_SETTINGCHANGE, 0, (IntPtr)Marshal.StringToHGlobalUni("SystemMetrics"));
                }
            }
        }
    }
}