namespace LoginScreen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtID = new TextBox();
            txtPW = new TextBox();
            btnLogin = new Button();
            lblErrorMsg = new Label();
            btnClear = new Button();
            chkShowPW = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 40F);
            label1.Location = new Point(108, 34);
            label1.Name = "label1";
            label1.Size = new Size(165, 72);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // txtID
            // 
            txtID.Font = new Font("맑은 고딕", 25F);
            txtID.ForeColor = Color.Silver;
            txtID.Location = new Point(43, 138);
            txtID.Name = "txtID";
            txtID.Size = new Size(301, 52);
            txtID.TabIndex = 2;
            txtID.Text = "아이디";
            txtID.Enter += txtID_Enter;
            txtID.KeyDown += txtID_KeyDown;
            txtID.Leave += txtID_Leave;
            // 
            // txtPW
            // 
            txtPW.Font = new Font("맑은 고딕", 25F);
            txtPW.ForeColor = Color.Silver;
            txtPW.Location = new Point(43, 216);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(301, 52);
            txtPW.TabIndex = 3;
            txtPW.Text = "패스워드";
            txtPW.Enter += txtPW_Enter;
            txtPW.KeyDown += txtPW_KeyDown;
            txtPW.Leave += txtPW_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.GradientActiveCaption;
            btnLogin.Font = new Font("맑은 고딕", 25F);
            btnLogin.ForeColor = SystemColors.HotTrack;
            btnLogin.Location = new Point(120, 313);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(133, 61);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.ForeColor = Color.Red;
            lblErrorMsg.Location = new Point(44, 278);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(230, 15);
            lblErrorMsg.TabIndex = 4;
            lblErrorMsg.Text = "아이디 또는 비밀번호가 잘못 되었습니다.";
            lblErrorMsg.Visible = false;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(280, 274);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "초기화";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // chkShowPW
            // 
            chkShowPW.AutoSize = true;
            chkShowPW.Location = new Point(350, 234);
            chkShowPW.Name = "chkShowPW";
            chkShowPW.Size = new Size(102, 19);
            chkShowPW.TabIndex = 6;
            chkShowPW.Text = "비밀번호 보기";
            chkShowPW.UseVisualStyleBackColor = true;
            chkShowPW.CheckedChanged += chkShowPW_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 451);
            Controls.Add(chkShowPW);
            Controls.Add(btnClear);
            Controls.Add(lblErrorMsg);
            Controls.Add(btnLogin);
            Controls.Add(txtPW);
            Controls.Add(txtID);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Login Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtID;
        private TextBox txtPW;
        private Button btnLogin;
        private Label lblErrorMsg;
        private Button btnClear;
        private CheckBox chkShowPW;
    }
}
