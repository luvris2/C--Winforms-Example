namespace C__Winform_Custom_Title_Bar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
        }

        // â �̵� ���� ���� ����
        bool mouseDown;
        Point lastLocation;

        // ���콺 ��Ŭ�� ��
        private void lbl_title_MouseDown(object sender, MouseEventArgs e)
        {
            // ���콺 Ŭ�� ����, ���� ������ ��ġ ����
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = true;
                lastLocation = e.Location;
            }
        }

        // ���콺 Ŭ���� ��ģ ��� Ŭ�� �̺�Ʈ
        private void lbl_title_MouseUp(object sender, MouseEventArgs e)
        {
            // ���콺 Ŭ�� ���� ����
            mouseDown = false;
        }

        // ���콺�� �� �̵� ��
        private void lbl_title_MouseMove(object sender, MouseEventArgs e)
        {
            // ���콺 Ŭ�� ���� �� ���� �̵��� ��ġ�� �̵�
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        // �ּ�ȭ
        private void btn_min_Click(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // �ִ�ȭ / �����·�
        private void btn_max_Click(object sender, MouseEventArgs e)
        {
            // �ִ�ȭ ���°� �ƴ� �� �ִ�ȭ
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            // �ִ�ȭ ������ �� �����·�
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        // �ݱ�
        private void btn_close_Click(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}