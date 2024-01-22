using System.Windows.Forms;

namespace C__ListBox_And_ListView_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 폼 로드
            Form1_Load(this, EventArgs.Empty);
        }

        // 폼 로드 시 값 설정
        private void Form1_Load(object sender, EventArgs e)
        {
            /* 리스트 박스 설정 */
            // 리스트박스의 값 설정 (항목 추가)
            listBox1.Items.Add("꼬부기");
            listBox1.Items.Add("이상해씨");
            listBox1.Items.Add("파이리");

            // 초기 인덱스 값 설정
            listBox1.SelectedIndex = 2; // 파이리 기본값으로 선택



            /* 리스트 뷰 설정 */
            // 리스트뷰의 값 설정 (항목 추가)
            ListViewItem item1 = new ListViewItem("꼬부기", 0);
            ListViewItem item2 = new ListViewItem("이상해씨", 1);
            ListViewItem item3 = new ListViewItem("파이리", 2);

            // 항목의 각 열의 데이터 추가
            item1.SubItems.Add("44");
            item1.SubItems.Add("48");
            item1.SubItems.Add("65");

            item2.SubItems.Add("45");
            item2.SubItems.Add("49");
            item2.SubItems.Add("49");

            item3.SubItems.Add("39");
            item3.SubItems.Add("52");
            item3.SubItems.Add("43");

            // 열의 헤더 이름 추가 : 컬럼명, 컬럼 사이즈 지정(생략 가능)
            listView1.Columns.Add("포켓몬");
            listView1.Columns.Add("HP");
            listView1.Columns.Add("공격");
            listView1.Columns.Add("방어");

            // 리스트뷰에 항목의 데이터 추가
            listView1.Items.Add(item1);
            listView1.Items.Add(item2);
            listView1.Items.Add(item3);
            // 아래의 코드로 일괄 추가 가능
            // listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3 });



            /* 리스트뷰 아이콘 설정 */
            // 리스트뷰의 항목에 보여질 이미지 리스트 생성
            ImageList imageListLarge = new ImageList();
            ImageList imageListSmall = new ImageList();

            // 이미지 리스트의 이미지 설정
            string curDir = getParentDirectory(); // 프로젝트 루트 디렉토리 경로
            imageListLarge.Images.Add(Bitmap.FromFile(curDir + "\\꼬부기.png"));
            imageListLarge.Images.Add(Bitmap.FromFile(curDir + "\\이상해씨.png"));
            imageListLarge.Images.Add(Bitmap.FromFile(curDir + "\\파이리.png"));

            imageListSmall.Images.Add(Bitmap.FromFile(curDir + "\\꼬부기.png"));
            imageListSmall.Images.Add(Bitmap.FromFile(curDir + "\\이상해씨.png"));
            imageListSmall.Images.Add(Bitmap.FromFile(curDir + "\\파이리.png"));

            // 리스트뷰에 이미지 항목 추가
            imageListLarge.ImageSize = new Size(64, 64); // 큰 아이콘의 크기
            imageListSmall.ImageSize = new Size(32, 32); // 작은 아이콘의 크기
            listView1.LargeImageList = imageListLarge;
            listView1.SmallImageList = imageListSmall;
        }

        // 리스트박스 항목 선택 시 항목 값 표시
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblListBox.Text = "당신이 선택한 포켓몬은 " + listBox1.Text.Trim() + "입니다.";
        }

        // 리스트뷰 항목 선택 시 항목 값 표시
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 리스트뷰에서 선택된 항목이 있는지 확인
            if (listView1.SelectedItems.Count > 0)
            {
                // 선택된 항목의 첫 번째 열(인덱스 0)의 값을 가져오기
                string selectedValue1 = listView1.SelectedItems[0].SubItems[0].Text;
                string selectedValue2 = listView1.SelectedItems[0].SubItems[1].Text;
                string selectedValue3 = listView1.SelectedItems[0].SubItems[2].Text;
                string selectedValue4 = listView1.SelectedItems[0].SubItems[3].Text;

                // 가져온 값을 출력하거나 필요한 작업 수행
                lblListView.Text = "[" + selectedValue1 + "] HP:" + selectedValue2 + ", 공격:" + selectedValue3 + ", 방어:" + selectedValue4;
            }
        }


        // 프로젝트 디렉토리 경로 확인
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



        // 뷰 모드 설정
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