namespace C__Winform_Radio_Group
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // �ʱⰪ ����
            radioPetY.Checked = true;
            radioPetMale.Checked = true;
        }

        private void radioPetY_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true; // �־ȵ��� ���� ���� ���� Ȱ��ȭ

            if (radioPetMale.Checked)   label1.Text = "�Ϳ��� ���Ƹ� Ű��� �ֱ���!";
            else   label1.Text = "�Ϳ��� ���Ƹ� Ű��� �ֱ���!";
        }

        private void radioPetN_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = false; // �־ȵ��� ���� ���� ���� ��Ȱ��ȭ
            label1.Text = "�ֿϵ����� Ű��� ���� �ʱ���.";
        }

        private void radioPetMale_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "�Ϳ��� ���Ƹ� Ű��� �ֱ���!";
        }

        private void radioPetFemale_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "�Ϳ��� ���Ƹ� Ű��� �ֱ���!";
        }
    }
}