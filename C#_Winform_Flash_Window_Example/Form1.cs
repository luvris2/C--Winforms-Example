namespace C__Winform_Flash_Window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        // FlashWindowEx를 사용하기 위한 DLL 파일 호출
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool FlashWindowEx(ref FLASHWINFO pwfi);

        // FLASHWINFO 구조체 정의
        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        private struct FLASHWINFO
        {
            public UInt32 cbSize; // 크기 지정
            public IntPtr hwnd; // 깜빡일 윈도우 핸들
            public UInt32 dwFlags; // 깜빡임 옵션
            public UInt32 uCount; // 깜빡일 횟수
            public UInt32 dwTimeout; // 깜빡임 간격
        }

        // FlashWindowEx 메서드 정의
        public bool FlashWindowEx(Form form, bool flashState)
        {
            FLASHWINFO fi = new FLASHWINFO();
            fi.cbSize = Convert.ToUInt32(System.Runtime.InteropServices.Marshal.SizeOf(fi));
            fi.hwnd = form.Handle;
            fi.dwTimeout = 0;

            if (flashState)
            {
                fi.dwFlags = 0x00000002; // 작업 표시줄 아이콘 깜빡이기
                fi.uCount = UInt32.MaxValue; // 깜빡임 횟수
            }
            else
            {
                // 깜빡임 중지
                fi.dwFlags = 0;
                fi.uCount = 0;
            }
            return FlashWindowEx(ref fi);
        }

        // 창의 최소화/보통/최대화 상태 감지
        private void Form_Resize(object sender, EventArgs e)
        {
            // 프로그램이 최소화되었을 때 작업표시줄 깜빡이기
            if (WindowState == FormWindowState.Minimized)   FlashWindowEx(this, true);
            // 프로그램이 원래 상태로 돌아왔을 때 작업표시줄 깜빡임 중지
            else   FlashWindowEx(this, false);
        }
    }
}