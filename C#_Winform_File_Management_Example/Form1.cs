namespace C__Winform_File_Management_Example
{
    public partial class Form1 : Form
    {

        // �⺻ ��� : ������Ʈ ���� ��θ� �������� ��
        string basePath = Environment.CurrentDirectory;

        public Form1()
        {
            InitializeComponent();
        }

        // �Է��� ���� �̸� ��������
        private string getFilePath()
        {
            return basePath + "\\" + txtOriginPath.Text;
        }

        // �Է��� ���ο� ���� �̸� ��������
        private string getNewFilePath()
        {
            return basePath + "\\" + txtNewPath.Text;
        }

        // ���� ��� ��ȿ�� Ȯ���ϱ�
        private void checkDirectory(string path)
        {
            // ���丮 ��θ� ����
            string directoryPath = Path.GetDirectoryName(path);

            // ��ΰ� �������� ������ ���丮 ����
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
        }

        // ���� �ҷ�����
        private void btnRead_Click(object sender, EventArgs e)
        {
            // �ؽ�Ʈ�� ǥ���� �ؽ�Ʈ�ڽ� �ʱ�ȭ
            txtContent.Text = "";

            // �ҷ��� ���� ��� Ȯ��
            string filePath = getFilePath();

            // ���� ��� ��ȿ�� Ȯ��
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    // ���� �б�
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        txtContent.Text += line + Environment.NewLine; // ���� �������̸� ���� �ٷ� �̵�
                    }
                }
            }
        }

        // ���� �����ϱ�
        private void btnSave_Click(object sender, EventArgs e)
        {
            // ������ ���� ��� Ȯ��
            string FilePath = getFilePath();

            // ������ ���� ����
            string content = txtContent.Text;

            // ���� ���� : false (�����)
            using (StreamWriter writer = new StreamWriter(FilePath, false))
            {
                writer.WriteLine(content);
            }
        }

        // �� ��ο� ���� �����ϱ�
        private void btnCopy_Click(object sender, EventArgs e)
        {
            // ���� ��� Ȯ��
            string filePath = getFilePath();

            // �� ���� ��� Ȯ��
            string newFilePath = getNewFilePath();

            // ���� ��� Ȯ��, ������ ���丮 ����
            checkDirectory(newFilePath);

            // ���� ����
            File.Copy(filePath, newFilePath, true);
        }

        // �� ��η� ���� �̵��ϱ�
        private void btnMove_Click(object sender, EventArgs e)
        {
            // ���� ��� Ȯ��
            string filePath = getFilePath();

            // �� ���� ��� Ȯ��
            string newFilePath = getNewFilePath();

            // ���� ��� Ȯ��, ������ ���丮 ����
            checkDirectory(newFilePath);

            // ���� �̵�
            File.Move(filePath, newFilePath, true);
        }

        // ���� �����ϱ�
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // ���� ��� Ȯ��
            string filePath = getFilePath();

            // ���� ����
            File.Delete(filePath);
        }
    }
}
