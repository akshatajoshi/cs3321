namespace LMS
{
    partial class login
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
            this.logingroupbox = new System.Windows.Forms.GroupBox();
            this.passwordcheckbox = new System.Windows.Forms.CheckBox();
            this.exitbutton = new System.Windows.Forms.Button();
            this.loginbutton = new System.Windows.Forms.Button();
            this.resetpasswordbutton = new System.Windows.Forms.Button();
            this.passwordtextbox = new System.Windows.Forms.TextBox();
            this.usernametextbox = new System.Windows.Forms.TextBox();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.errormessagelabel = new System.Windows.Forms.Label();
            this.logingroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // logingroupbox
            // 
            this.logingroupbox.Controls.Add(this.passwordcheckbox);
            this.logingroupbox.Controls.Add(this.exitbutton);
            this.logingroupbox.Controls.Add(this.loginbutton);
            this.logingroupbox.Controls.Add(this.resetpasswordbutton);
            this.logingroupbox.Controls.Add(this.passwordtextbox);
            this.logingroupbox.Controls.Add(this.usernametextbox);
            this.logingroupbox.Controls.Add(this.passwordlabel);
            this.logingroupbox.Controls.Add(this.usernamelabel);
            this.logingroupbox.Location = new System.Drawing.Point(12, 32);
            this.logingroupbox.Name = "logingroupbox";
            this.logingroupbox.Size = new System.Drawing.Size(297, 98);
            this.logingroupbox.TabIndex = 0;
            this.logingroupbox.TabStop = false;
            this.logingroupbox.Text = "Login";
            // 
            // passwordcheckbox
            // 
            this.passwordcheckbox.AutoSize = true;
            this.passwordcheckbox.Location = new System.Drawing.Point(229, 43);
            this.passwordcheckbox.Name = "passwordcheckbox";
            this.passwordcheckbox.Size = new System.Drawing.Size(53, 17);
            this.passwordcheckbox.TabIndex = 2;
            this.passwordcheckbox.Text = "Show";
            this.passwordcheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.passwordcheckbox.UseVisualStyleBackColor = true;
            this.passwordcheckbox.CheckedChanged += new System.EventHandler(this.passwordcheckbox_CheckedChanged);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(215, 67);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(75, 23);
            this.exitbutton.TabIndex = 7;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(134, 67);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(75, 23);
            this.loginbutton.TabIndex = 6;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // resetpasswordbutton
            // 
            this.resetpasswordbutton.Location = new System.Drawing.Point(6, 67);
            this.resetpasswordbutton.Name = "resetpasswordbutton";
            this.resetpasswordbutton.Size = new System.Drawing.Size(122, 23);
            this.resetpasswordbutton.TabIndex = 5;
            this.resetpasswordbutton.Text = "Forgot your password?";
            this.resetpasswordbutton.UseVisualStyleBackColor = true;
            this.resetpasswordbutton.Click += new System.EventHandler(this.resetpasswordbutton_Click);
            // 
            // passwordtextbox
            // 
            this.passwordtextbox.Location = new System.Drawing.Point(123, 41);
            this.passwordtextbox.Name = "passwordtextbox";
            this.passwordtextbox.Size = new System.Drawing.Size(100, 20);
            this.passwordtextbox.TabIndex = 3;
            // 
            // usernametextbox
            // 
            this.usernametextbox.Location = new System.Drawing.Point(123, 13);
            this.usernametextbox.Name = "usernametextbox";
            this.usernametextbox.Size = new System.Drawing.Size(100, 20);
            this.usernametextbox.TabIndex = 2;
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Location = new System.Drawing.Point(61, 41);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(56, 13);
            this.passwordlabel.TabIndex = 1;
            this.passwordlabel.Text = "Password:";
            this.passwordlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Location = new System.Drawing.Point(59, 16);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(58, 13);
            this.usernamelabel.TabIndex = 0;
            this.usernamelabel.Text = "Username:";
            this.usernamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errormessagelabel
            // 
            this.errormessagelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errormessagelabel.ForeColor = System.Drawing.Color.Red;
            this.errormessagelabel.Location = new System.Drawing.Point(12, 11);
            this.errormessagelabel.Name = "errormessagelabel";
            this.errormessagelabel.Size = new System.Drawing.Size(287, 18);
            this.errormessagelabel.TabIndex = 1;
            this.errormessagelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 139);
            this.Controls.Add(this.errormessagelabel);
            this.Controls.Add(this.logingroupbox);
            this.Name = "login";
            this.Text = "CS 3321 LMS";
            this.logingroupbox.ResumeLayout(false);
            this.logingroupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox logingroupbox;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Button resetpasswordbutton;
        public System.Windows.Forms.TextBox usernametextbox;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Label errormessagelabel;
        private System.Windows.Forms.CheckBox passwordcheckbox;
        private System.Windows.Forms.TextBox passwordtextbox;
    }
}

