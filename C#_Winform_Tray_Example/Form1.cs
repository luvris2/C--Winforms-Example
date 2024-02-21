namespace C__Tray_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ���� ���� �� �߻��Ǵ� �̺�Ʈ : ��׶��� ����
        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            // CloseReason.UserClosing : ����ڰ� �ݱ� ��ư�� ���� ��
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // �� �ݱ� �̺�Ʈ ���
                e.Cancel = true;
                // �� �����
                this.Hide();
            }
        }

        // ���� ���
        private void ContextMenuStrip_Open(object sender, EventArgs e)
        {
            this.Show();
            //this.Visible = true;
        }

        // ���� ���
        private void ContextMenuStrip_Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}