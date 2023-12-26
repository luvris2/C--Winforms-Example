namespace C__Winform_Radio_Group
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 초기값 설정
            radioPetY.Checked = true;
            radioPetMale.Checked = true;
        }

        private void radioPetY_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true; // 애안동물 성별 선택 여부 활성화

            if (radioPetMale.Checked)   label1.Text = "귀여운 남아를 키우고 있군요!";
            else   label1.Text = "귀여운 여아를 키우고 있군요!";
        }

        private void radioPetN_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = false; // 애안동물 성별 선택 여부 비활성화
            label1.Text = "애완동물을 키우고 있지 않군요.";
        }

        private void radioPetMale_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "귀여운 남아를 키우고 있군요!";
        }

        private void radioPetFemale_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "귀여운 여아를 키우고 있군요!";
        }
    }
}