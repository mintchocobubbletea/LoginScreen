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
            txtID.Location = new Point(64, 135);
            txtID.Name = "txtID";
            txtID.Size = new Size(257, 52);
            txtID.TabIndex = 1;
            txtID.Text = "아이디";
            // 
            // txtPW
            // 
            txtPW.Font = new Font("맑은 고딕", 25F);
            txtPW.ForeColor = Color.Silver;
            txtPW.Location = new Point(64, 213);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(257, 52);
            txtPW.TabIndex = 1;
            txtPW.Text = "패스워드";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.GradientActiveCaption;
            btnLogin.Font = new Font("맑은 고딕", 25F);
            btnLogin.ForeColor = SystemColors.HotTrack;
            btnLogin.Location = new Point(120, 313);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(133, 61);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 451);
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
    }
}
