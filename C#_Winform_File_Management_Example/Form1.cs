namespace C__Winform_File_Management_Example
{
    public partial class Form1 : Form
    {

        // 기본 경로 : 프로젝트 실행 경로를 기준으로 함
        string basePath = Environment.CurrentDirectory;

        public Form1()
        {
            InitializeComponent();
        }

        // 입력한 파일 이름 가져오기
        private string getFilePath()
        {
            return basePath + "\\" + txtOriginPath.Text;
        }

        // 입력한 새로운 파일 이름 가져오기
        private string getNewFilePath()
        {
            return basePath + "\\" + txtNewPath.Text;
        }

        // 파일 경로 유효성 확인하기
        private void checkDirectory(string path)
        {
            // 디렉토리 경로만 추출
            string directoryPath = Path.GetDirectoryName(path);

            // 경로가 존재하지 않으면 디렉토리 생성
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
        }

        // 파일 불러오기
        private void btnRead_Click(object sender, EventArgs e)
        {
            // 텍스트를 표시할 텍스트박스 초기화
            txtContent.Text = "";

            // 불러올 파일 경로 확인
            string filePath = getFilePath();

            // 파일 경로 유효성 확인
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    // 파일 읽기
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        txtContent.Text += line + Environment.NewLine; // 줄의 마지막이면 다음 줄로 이동
                    }
                }
            }
        }

        // 파일 저장하기
        private void btnSave_Click(object sender, EventArgs e)
        {
            // 저장할 파일 경로 확인
            string FilePath = getFilePath();

            // 저장할 파일 내용
            string content = txtContent.Text;

            // 파일 쓰기 : false (덮어쓰기)
            using (StreamWriter writer = new StreamWriter(FilePath, false))
            {
                writer.WriteLine(content);
            }
        }

        // 새 경로에 파일 복사하기
        private void btnCopy_Click(object sender, EventArgs e)
        {
            // 파일 경로 확인
            string filePath = getFilePath();

            // 새 파일 경로 확인
            string newFilePath = getNewFilePath();

            // 파일 경로 확인, 없으면 디렉토리 생성
            checkDirectory(newFilePath);

            // 파일 복사
            File.Copy(filePath, newFilePath, true);
        }

        // 새 경로로 파일 이동하기
        private void btnMove_Click(object sender, EventArgs e)
        {
            // 파일 경로 확인
            string filePath = getFilePath();

            // 새 파일 경로 확인
            string newFilePath = getNewFilePath();

            // 파일 경로 확인, 없으면 디렉토리 생성
            checkDirectory(newFilePath);

            // 파일 이동
            File.Move(filePath, newFilePath, true);
        }

        // 파일 삭제하기
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 파일 경로 확인
            string filePath = getFilePath();

            // 파일 삭제
            File.Delete(filePath);
        }
    }
}
