namespace DoctorWorkstation
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_user = new System.Windows.Forms.ComboBox();
            this.lbl_user = new System.Windows.Forms.Label();
            this.txtBox_Password = new System.Windows.Forms.TextBox();
            this.txtBox_Account = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.lbl_Account = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_user
            // 
            this.comboBox_user.FormattingEnabled = true;
            this.comboBox_user.Items.AddRange(new object[] {
            "门诊部",
            "住院部"});
            this.comboBox_user.Location = new System.Drawing.Point(181, 211);
            this.comboBox_user.Name = "comboBox_user";
            this.comboBox_user.Size = new System.Drawing.Size(325, 26);
            this.comboBox_user.TabIndex = 21;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(22, 219);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(98, 18);
            this.lbl_user.TabIndex = 20;
            this.lbl_user.Text = "用户类别：";
            // 
            // txtBox_Password
            // 
            this.txtBox_Password.Location = new System.Drawing.Point(181, 121);
            this.txtBox_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_Password.Name = "txtBox_Password";
            this.txtBox_Password.Size = new System.Drawing.Size(325, 28);
            this.txtBox_Password.TabIndex = 19;
            this.txtBox_Password.UseSystemPasswordChar = true;
            // 
            // txtBox_Account
            // 
            this.txtBox_Account.Location = new System.Drawing.Point(181, 32);
            this.txtBox_Account.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_Account.Name = "txtBox_Account";
            this.txtBox_Account.Size = new System.Drawing.Size(325, 28);
            this.txtBox_Account.TabIndex = 18;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(67, 131);
            this.label_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(53, 18);
            this.label_Password.TabIndex = 17;
            this.label_Password.Text = "密码:";
            // 
            // lbl_Account
            // 
            this.lbl_Account.AutoSize = true;
            this.lbl_Account.Location = new System.Drawing.Point(67, 45);
            this.lbl_Account.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Account.Name = "lbl_Account";
            this.lbl_Account.Size = new System.Drawing.Size(53, 18);
            this.lbl_Account.TabIndex = 16;
            this.lbl_Account.Text = "账号:";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(265, 304);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(112, 34);
            this.btn_Login.TabIndex = 15;
            this.btn_Login.Text = "登录";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 364);
            this.Controls.Add(this.comboBox_user);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.txtBox_Password);
            this.Controls.Add(this.txtBox_Account);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.lbl_Account);
            this.Controls.Add(this.btn_Login);
            this.Name = "Login";
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_user;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.TextBox txtBox_Password;
        private System.Windows.Forms.TextBox txtBox_Account;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label lbl_Account;
        private System.Windows.Forms.Button btn_Login;
    }
}

