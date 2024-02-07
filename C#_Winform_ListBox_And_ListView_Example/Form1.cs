using System.Windows.Forms;

namespace C__ListBox_And_ListView_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // �� �ε�
            Form1_Load(this, EventArgs.Empty);
        }

        // �� �ε� �� �� ����
        private void Form1_Load(object sender, EventArgs e)
        {
            /* ����Ʈ �ڽ� ���� */
            // ����Ʈ�ڽ��� �� ���� (�׸� �߰�)
            listBox1.Items.Add("���α�");
            listBox1.Items.Add("�̻��ؾ�");
            listBox1.Items.Add("���̸�");

            // �ʱ� �ε��� �� ����
            listBox1.SelectedIndex = 2; // ���̸� �⺻������ ����



            /* ����Ʈ �� ���� */
            // ����Ʈ���� �� ���� (�׸� �߰�)
            ListViewItem item1 = new ListViewItem("���α�", 0);
            ListViewItem item2 = new ListViewItem("�̻��ؾ�", 1);
            ListViewItem item3 = new ListViewItem("���̸�", 2);

            // �׸��� �� ���� ������ �߰�
            item1.SubItems.Add("44");
            item1.SubItems.Add("48");
            item1.SubItems.Add("65");

            item2.SubItems.Add("45");
            item2.SubItems.Add("49");
            item2.SubItems.Add("49");

            item3.SubItems.Add("39");
            item3.SubItems.Add("52");
            item3.SubItems.Add("43");

            // ���� ��� �̸� �߰� : �÷���, �÷� ������ ����(���� ����)
            listView1.Columns.Add("���ϸ�");
            listView1.Columns.Add("HP");
            listView1.Columns.Add("����");
            listView1.Columns.Add("���");

            // ����Ʈ�信 �׸��� ������ �߰�
            listView1.Items.Add(item1);
            listView1.Items.Add(item2);
            listView1.Items.Add(item3);
            // �Ʒ��� �ڵ�� �ϰ� �߰� ����
            // listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3 });



            /* ����Ʈ�� ������ ���� */
            // ����Ʈ���� �׸� ������ �̹��� ����Ʈ ����
            ImageList imageListLarge = new ImageList();
            ImageList imageListSmall = new ImageList();

            // �̹��� ����Ʈ�� �̹��� ����
            string curDir = getParentDirectory(); // ������Ʈ ��Ʈ ���丮 ���
            imageListLarge.Images.Add(Bitmap.FromFile(curDir + "\\���α�.png"));
            imageListLarge.Images.Add(Bitmap.FromFile(curDir + "\\�̻��ؾ�.png"));
            imageListLarge.Images.Add(Bitmap.FromFile(curDir + "\\���̸�.png"));

            imageListSmall.Images.Add(Bitmap.FromFile(curDir + "\\���α�.png"));
            imageListSmall.Images.Add(Bitmap.FromFile(curDir + "\\�̻��ؾ�.png"));
            imageListSmall.Images.Add(Bitmap.FromFile(curDir + "\\���̸�.png"));

            // ����Ʈ�信 �̹��� �׸� �߰�
            imageListLarge.ImageSize = new Size(64, 64); // ū �������� ũ��
            imageListSmall.ImageSize = new Size(32, 32); // ���� �������� ũ��
            listView1.LargeImageList = imageListLarge;
            listView1.SmallImageList = imageListSmall;
        }

        // ����Ʈ�ڽ� �׸� ���� �� �׸� �� ǥ��
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblListBox.Text = "����� ������ ���ϸ��� " + listBox1.Text.Trim() + "�Դϴ�.";
        }

        // ����Ʈ�� �׸� ���� �� �׸� �� ǥ��
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ����Ʈ�信�� ���õ� �׸��� �ִ��� Ȯ��
            if (listView1.SelectedItems.Count > 0)
            {
                // ���õ� �׸��� ù ��° ��(�ε��� 0)�� ���� ��������
                string selectedValue1 = listView1.SelectedItems[0].SubItems[0].Text;
                string selectedValue2 = listView1.SelectedItems[0].SubItems[1].Text;
                string selectedValue3 = listView1.SelectedItems[0].SubItems[2].Text;
                string selectedValue4 = listView1.SelectedItems[0].SubItems[3].Text;

                // ������ ���� ����ϰų� �ʿ��� �۾� ����
                lblListView.Text = "[" + selectedValue1 + "] HP:" + selectedValue2 + ", ����:" + selectedValue3 + ", ���:" + selectedValue4;
            }
        }


        // ������Ʈ ���丮 ��� Ȯ��
        private string getParentDirectory()
        {
            string curDir = Directory.GetCurrentDirectory();
            DirectoryInfo parentDir = Directory.GetParent(curDir);
            curDir = parentDir.FullName;
            parentDir = Directory.GetParent(curDir);
            curDir = parentDir.FullName;
            parentDir = Directory.GetParent(curDir);
            curDir = parentDir.FullName;

            return curDir;
        }



        // �� ��� ����
        private void radioIconL_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void radioIconS_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void radioList_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void radioDetail_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void radioTile_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }
    }
}