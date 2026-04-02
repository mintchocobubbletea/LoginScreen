namespace LoginScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "아이디")
            {
                txtID.Text = "";
                txtID.ForeColor = Color.Black;
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                txtID.Text = "아이디";
                txtID.ForeColor = Color.Silver;
            }
        }

        private void txtPW_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPW.Text))
            {
                txtPW.UseSystemPasswordChar = false;
                txtPW.Text = "패스워드";
                txtPW.ForeColor = Color.Silver;
            }
        }

        private void txtPW_Enter(object sender, EventArgs e)
        {
            if (txtPW.Text == "패스워드")
            {
                txtPW.Text = "";
                txtPW.ForeColor = Color.Black;
                txtPW.UseSystemPasswordChar = true;
            }
        }

        string myID = "admin";
        string myPW = "superman1";
        int loginFailCount = 0; // 실패 횟수 저장
        int waitTime = 30;     // 재시도 대기 시간(초)
        private bool IsValidInput(string id, string pw)
        {
            // 아이디에 공백이 포함되어 있는지 확인
            if (id.Contains(" "))
            {
                lblErrorMsg.Text = "아이디에 공백을 포함할 수 없습니다.";
                return false;
            }

            // 비밀번호는 최소 8자 이상, 숫자 포함 필수
            bool hasNumber = pw.Any(char.IsDigit);
            if (pw.Length < 8 || !hasNumber)
            {
                lblErrorMsg.Text = "비밀번호는 8자 이상이며 숫자를 포함해야 합니다.";
                return false;
            }

            return true;
        }
        //로그인 함수
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string inputID = txtID.Text; string inputPW = txtPW.Text;
            if (!IsValidInput(inputID, inputPW)) { lblErrorMsg.Visible = true; return; }

            if (inputID == myID && inputPW == myPW)
            {
                lblErrorMsg.Visible = false;
                MessageBox.Show("로그인 성공!", "로그인", MessageBoxButtons.OK);
            }
            else
            {
                loginFailCount++;
                lblErrorMsg.Visible = true;

                if (loginFailCount >= 5)
                {
                    btnLogin.Enabled = false;
                    lblErrorMsg.Text = "5회 실패! 30초 후 다시 시도하세요.";

                    await Task.Delay(waitTime * 1000); // 비동기 대기

                    btnLogin.Enabled = true;
                    loginFailCount = 0;
                    lblErrorMsg.Text = "다시 시도할 수 있습니다.";
                }
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // 기본 비프음 방지
                txtPW.Focus(); // 패스워드 입력창이 포커스를 갖게끔
            }
        }

        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // 기본 비프음 방지
                btnLogin.PerformClick(); // 버튼이 눌린 것처럼 만들기
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // 아이디 초기화
            txtID.Text = "아이디";
            txtID.ForeColor = Color.Silver;

            // 패스워드 초기화 및 마스킹 해제
            txtPW.Text = "패스워드";
            txtPW.ForeColor = Color.Silver;
            txtPW.UseSystemPasswordChar = false;

            // 첫 번째 입력창으로 포커스 이동
            txtID.Focus();

            // 에러 메시지도 숨기기
            lblErrorMsg.Visible = false;
        }

        private void chkShowPW_CheckedChanged(object sender, EventArgs e)
        {
            // Placeholder 상태(패스워드 글자가 적힌 상태)가 아닐 때만 작동하도록 조건 추가 가능
            if (txtPW.Text != "패스워드")
            {
                // 체크박스가 체크되어 있으면 글자를 보여주고, 해제되면 마스킹(*) 처리
                if (chkShowPW.Checked)
                {
                    txtPW.UseSystemPasswordChar = false;
                }
                else
                {
                    txtPW.UseSystemPasswordChar = true;
                }
            }
        }

        
       
        

    }
}
