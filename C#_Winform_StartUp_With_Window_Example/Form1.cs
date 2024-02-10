using Microsoft.Win32;

namespace C__Winform_StartUp_With_Window_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartWithWindow(bool state)
        {
            string regStartUpPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
            string programName = "luvris2";
            RegistryKey key = Registry.CurrentUser.OpenSubKey(regStartUpPath, true);

            // ������ ���� �� �ڵ� ����
            if (state)
                key.SetValue(programName, Environment.CurrentDirectory + "\\BabyChat.exe");
            // ������ ���� �� �ڵ� �������� �ʱ�
            else
                key.DeleteValue(programName, false);
        }

        private void btnStartUpOn_Click(object sender, EventArgs e)
        {
            StartWithWindow(true);
            MessageBox.Show("������ ���� ���� ��Ͽ� �߰��Ͽ����ϴ�.");
        }

        private void btnStartUpOff_Click(object sender, EventArgs e)
        {
            StartWithWindow(false);
            MessageBox.Show("������ ���� ���� ��Ͽ��� �����Ͽ����ϴ�.");
        }
    }
}
