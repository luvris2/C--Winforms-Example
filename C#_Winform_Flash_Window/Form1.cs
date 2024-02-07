namespace C__Winform_Flash_Window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        // FlashWindowEx�� ����ϱ� ���� DLL ���� ȣ��
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool FlashWindowEx(ref FLASHWINFO pwfi);

        // FLASHWINFO ����ü ����
        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        private struct FLASHWINFO
        {
            public UInt32 cbSize; // ũ�� ����
            public IntPtr hwnd; // ������ ������ �ڵ�
            public UInt32 dwFlags; // ������ �ɼ�
            public UInt32 uCount; // ������ Ƚ��
            public UInt32 dwTimeout; // ������ ����
        }

        // FlashWindowEx �޼��� ����
        public bool FlashWindowEx(Form form, bool flashState)
        {
            FLASHWINFO fi = new FLASHWINFO();
            fi.cbSize = Convert.ToUInt32(System.Runtime.InteropServices.Marshal.SizeOf(fi));
            fi.hwnd = form.Handle;
            fi.dwTimeout = 0;

            if (flashState)
            {
                fi.dwFlags = 0x00000002; // �۾� ǥ���� ������ �����̱�
                fi.uCount = UInt32.MaxValue; // ������ Ƚ��
            }
            else
            {
                // ������ ����
                fi.dwFlags = 0;
                fi.uCount = 0;
            }
            return FlashWindowEx(ref fi);
        }

        // â�� �ּ�ȭ/����/�ִ�ȭ ���� ����
        private void Form_Resize(object sender, EventArgs e)
        {
            // ���α׷��� �ּ�ȭ�Ǿ��� �� �۾�ǥ���� �����̱�
            if (WindowState == FormWindowState.Minimized)   FlashWindowEx(this, true);
            // ���α׷��� ���� ���·� ���ƿ��� �� �۾�ǥ���� ������ ����
            else   FlashWindowEx(this, false);
        }
    }
}