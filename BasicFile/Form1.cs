using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BasicFile
{
    public partial class Form1 : Form
    {
        public static bool chk = false;
        public Form1()
        {
            InitializeComponent();
            InitVariables();
            LoadStatic(); // 프로그램 시작시 학생 수 자동 로드가 체크 되어 있으면 저장 값 로드
            if (chk == true) Loading(); //LoadStatic() 함수에 넣을 경우, BinaryReader가 두 개 동시에 열려 오류/예외처리가 나옴. 따라서 로드 함수만 따로 빼놓음.

        }

        //성별 초기값 남자로 설정
        private void InitVariables()
        {
            comboBoxGender1.SelectedIndex = 0;
            comboBoxGender2.SelectedIndex = 0;
            comboBoxGender3.SelectedIndex = 0;
        }
        private void label13_Click(object sender, EventArgs e)
        {

        }

        

        // 화면의 모든 데이터 값을 a.dat으로 저장하는 함수
        public void Writing()
        {
            BinaryWriter bw = new BinaryWriter(new FileStream("a.dat", FileMode.Create));
            //BinaryWriter을 이용해 데이터 저장
            
            bw.Write(textBoxStudent1.Text);
            bw.Write(textBoxNum1.Text);
            bw.Write(comboBoxGender1.Text);
            bw.Write(textBoxMemo1.Text);

            bw.Write(textBoxStudent2.Text);
            bw.Write(textBoxNum2.Text);
            bw.Write(comboBoxGender2.Text);
            bw.Write(textBoxMemo2.Text);

            bw.Write(textBoxStudent3.Text);
            bw.Write(textBoxNum3.Text);
            bw.Write(comboBoxGender3.Text);
            bw.Write(textBoxMemo3.Text);
            bw.Write(checkBoxAutoLoad.Checked);

            bw.Close();
        }

        //화면의 모든 데이터 값을 a.dat으로부터 load하는 함수
        public void Loading()
        {
            
            BinaryReader br = new BinaryReader(new FileStream("a.dat", FileMode.Open)); //BinaryReader을 사용해서 데이터 로드
           
            textBoxStudent1.Text = br.ReadString();
            textBoxNum1.Text = br.ReadString();
            comboBoxGender1.Text = br.ReadString();
            textBoxMemo1.Text = br.ReadString();

            textBoxStudent2.Text = br.ReadString();
            textBoxNum2.Text = br.ReadString();
            comboBoxGender2.Text = br.ReadString();
            textBoxMemo2.Text = br.ReadString();

            textBoxStudent3.Text = br.ReadString();
            textBoxNum3.Text = br.ReadString();
            comboBoxGender3.Text = br.ReadString();
            textBoxMemo3.Text = br.ReadString();
            checkBoxAutoLoad.Checked = br.ReadBoolean();
            Countstudent();

            br.Close();
        }

        //저장하기 버튼 클릭 시 writing()함수 실행
        private void buttonSave1_Click(object sender, EventArgs e)
        {
            Writing();
        }
        private void buttonSave2_Click(object sender, EventArgs e)
        {
            Writing();
        }

        private void buttonSave3_Click(object sender, EventArgs e)
        {
            Writing();
        }
        
        //학생정보 불러오기 버튼 클릭 시 Loading()함수 실행
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            Loading();
        }

        //학생 정보 삭제 기능
        //삭제 버튼 클릭 시 해당 group의 text 데이터 기본값으로 초기화 후, 자동 저장 후 불러오기
        //해당 그룹이 즉시 삭제되어 사용자가 삭제가 되었는지 가시적으로 확인 가능.
        private void buttonDelete1_Click(object sender, EventArgs e)
        {
            //데이터 초기값으로 설정
            textBoxStudent1.Text = "학생정보 없음";
            textBoxNum1.Text = null;
            comboBoxGender1.SelectedIndex = 0;
            textBoxMemo1.Text = null;
            
            //저장 후 재로딩
            Writing();
            Loading();
        }

        private void buttonDelete2_Click(object sender, EventArgs e)
        {
           
            textBoxStudent2.Text = "학생정보 없음";
            textBoxNum2.Text = null;
            comboBoxGender2.SelectedIndex = 0;
            textBoxMemo2.Text = null;
            Writing();
            Loading();
           
        }

        private void buttonDelete3_Click(object sender, EventArgs e)
        {
            textBoxStudent3.Text = "학생정보 없음";
            textBoxNum3.Text = null;
            comboBoxGender3.SelectedIndex = 0;
            textBoxMemo3.Text = null;
            Writing();
            Loading();
        }

        //체크박스 변동에 따른 파일에프로그램 시작시 학생 수 자동 로드가 체크 여부 저장
        //체크박스 변동 시 b.dat의 파일에프로그램 시작시 학생 수 자동 로드가 체크 여부 저장
        private void checkBoxAutoLoad_CheckedChanged(object sender, EventArgs e)
        {
            BinaryWriter bbw = new BinaryWriter(new FileStream("b.dat", FileMode.Create)); //새로운 파일 b.dat에 저장
            bbw.Write(checkBoxAutoLoad.Checked);
            bbw.Close();
        }

        //시작 시 학생 수 자동 로드
        //b.dat에서 프로그램 시작시 학생 수 자동 로드가 체크 여부를 로드하여 static bool값 chk에 저장 
        private void LoadStatic()
        {
            BinaryReader bbr = new BinaryReader(new FileStream("b.dat", FileMode.Open));
            chk = bbr.ReadBoolean();
            bbr.Close();

        } 
        //학생 수 세기
        //학생의 이름값을 기준으로, 이름이 초기값이면 -를, 아니라면 +하여 cnt값에 저장하고 레이블로 표시
        private void Countstudent()
        {
            int cnt = 0;

            if (textBoxStudent1.Text != "학생정보 없음") cnt++; //학생 수가 기본값이 아니라면 cnt++
            //else cnt--;
            if (textBoxStudent2.Text != "학생정보 없음") cnt++;
            //else cnt--;
            if (textBoxStudent3.Text != "학생정보 없음") cnt++;
            //else cnt--;
            labelStudentCnt.Text = "현재 저장된 학생 수 : " + cnt;
            
        }
    }
}