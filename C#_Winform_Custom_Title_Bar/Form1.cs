namespace C__Winform_Custom_Title_Bar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
        }

        // 창 이동 관련 전역 변수
        bool mouseDown;
        Point lastLocation;

        // 마우스 좌클릭 시
        private void lbl_title_MouseDown(object sender, MouseEventArgs e)
        {
            // 마우스 클릭 여부, 폼의 마지막 위치 저장
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = true;
                lastLocation = e.Location;
            }
        }

        // 마우스 클릭을 마친 경우 클릭 이벤트
        private void lbl_title_MouseUp(object sender, MouseEventArgs e)
        {
            // 마우스 클릭 여부 저장
            mouseDown = false;
        }

        // 마우스로 폼 이동 시
        private void lbl_title_MouseMove(object sender, MouseEventArgs e)
        {
            // 마우스 클릭 상태 시 폼이 이동된 위치로 이동
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        // 최소화
        private void btn_min_Click(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // 최대화 / 원상태로
        private void btn_max_Click(object sender, MouseEventArgs e)
        {
            // 최대화 상태가 아닐 때 최대화
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            // 최대화 상태일 때 원상태로
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        // 닫기
        private void btn_close_Click(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}