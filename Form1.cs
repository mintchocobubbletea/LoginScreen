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
        string myPW = "superman";

        //로그인 함수
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputID = txtID.Text;
            string inputPW = txtPW.Text;
            if (inputID == myID && inputPW == myPW)
            {
                lblErrorMsg.Visible = false;
                MessageBox.Show("로그인 성공!", "로그인", MessageBoxButtons.OK);
            }
            else
            {
                lblErrorMsg.Visible = true;
                //MessageBox.Show("로그인 실패~", "로그인", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
