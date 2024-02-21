namespace C__Tray_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 폼이 닫힐 때 발생되는 이벤트 : 백그라운드 실행
        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            // CloseReason.UserClosing : 사용자가 닫기 버튼을 누를 때
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // 폼 닫기 이벤트 취소
                e.Cancel = true;
                // 폼 숨기기
                this.Hide();
            }
        }

        // 열기 기능
        private void ContextMenuStrip_Open(object sender, EventArgs e)
        {
            this.Show();
            //this.Visible = true;
        }

        // 종료 기능
        private void ContextMenuStrip_Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}