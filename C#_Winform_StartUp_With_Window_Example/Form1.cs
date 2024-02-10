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

            // 윈도우 시작 시 자동 실행
            if (state)
                key.SetValue(programName, Environment.CurrentDirectory + "\\BabyChat.exe");
            // 윈도우 시작 시 자동 실행하지 않기
            else
                key.DeleteValue(programName, false);
        }

        private void btnStartUpOn_Click(object sender, EventArgs e)
        {
            StartWithWindow(true);
            MessageBox.Show("윈도우 시작 실행 목록에 추가하였습니다.");
        }

        private void btnStartUpOff_Click(object sender, EventArgs e)
        {
            StartWithWindow(false);
            MessageBox.Show("윈도우 시작 실행 목록에서 삭제하였습니다.");
        }
    }
}
