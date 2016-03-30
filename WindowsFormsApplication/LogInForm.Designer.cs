namespace WindowsFormsApplication
{
    partial class LogInForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tablogin = new System.Windows.Forms.TabPage();
            this.linklRegister = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbLoginUsername = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.tabRegister = new System.Windows.Forms.TabPage();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.tbCreateUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCtrl.SuspendLayout();
            this.tablogin.SuspendLayout();
            this.tabRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrl
            // 
            this.tabCtrl.Controls.Add(this.tablogin);
            this.tabCtrl.Controls.Add(this.tabRegister);
            this.tabCtrl.Location = new System.Drawing.Point(16, 15);
            this.tabCtrl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(836, 476);
            this.tabCtrl.TabIndex = 1;
            // 
            // tablogin
            // 
            this.tablogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.tablogin.Controls.Add(this.linklRegister);
            this.tablogin.Controls.Add(this.btnLogin);
            this.tablogin.Controls.Add(this.tbLoginUsername);
            this.tablogin.Controls.Add(this.lbUsername);
            this.tablogin.Location = new System.Drawing.Point(4, 25);
            this.tablogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tablogin.Name = "tablogin";
            this.tablogin.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tablogin.Size = new System.Drawing.Size(828, 447);
            this.tablogin.TabIndex = 0;
            this.tablogin.Text = "Log in";
            // 
            // linklRegister
            // 
            this.linklRegister.AutoSize = true;
            this.linklRegister.Location = new System.Drawing.Point(221, 202);
            this.linklRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linklRegister.Name = "linklRegister";
            this.linklRegister.Size = new System.Drawing.Size(139, 17);
            this.linklRegister.TabIndex = 3;
            this.linklRegister.TabStop = true;
            this.linklRegister.Text = "Registrer a new user";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(367, 133);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 28);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // tbLoginUsername
            // 
            this.tbLoginUsername.Location = new System.Drawing.Point(225, 135);
            this.tbLoginUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLoginUsername.Name = "tbLoginUsername";
            this.tbLoginUsername.Size = new System.Drawing.Size(132, 22);
            this.tbLoginUsername.TabIndex = 1;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.ForeColor = System.Drawing.Color.White;
            this.lbUsername.Location = new System.Drawing.Point(221, 116);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(124, 17);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "Type in Username";
            // 
            // tabRegister
            // 
            this.tabRegister.Controls.Add(this.btnCreateUser);
            this.tabRegister.Controls.Add(this.tbCreateUser);
            this.tabRegister.Controls.Add(this.label1);
            this.tabRegister.Location = new System.Drawing.Point(4, 25);
            this.tabRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabRegister.Name = "tabRegister";
            this.tabRegister.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabRegister.Size = new System.Drawing.Size(828, 447);
            this.tabRegister.TabIndex = 1;
            this.tabRegister.Text = "New User";
            this.tabRegister.UseVisualStyleBackColor = true;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateUser.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCreateUser.Location = new System.Drawing.Point(364, 134);
            this.btnCreateUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(100, 28);
            this.btnCreateUser.TabIndex = 6;
            this.btnCreateUser.Text = "Create User";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            // 
            // tbCreateUser
            // 
            this.tbCreateUser.Location = new System.Drawing.Point(222, 136);
            this.tbCreateUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCreateUser.Name = "tbCreateUser";
            this.tbCreateUser.Size = new System.Drawing.Size(132, 22);
            this.tbCreateUser.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type in Username";
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(868, 506);
            this.Controls.Add(this.tabCtrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogInForm";
            this.tabCtrl.ResumeLayout(false);
            this.tablogin.ResumeLayout(false);
            this.tablogin.PerformLayout();
            this.tabRegister.ResumeLayout(false);
            this.tabRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.TabPage tablogin;
        private System.Windows.Forms.LinkLabel linklRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbLoginUsername;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TabPage tabRegister;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.TextBox tbCreateUser;
        private System.Windows.Forms.Label label1;
    }
}