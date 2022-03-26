namespace ShoppingMart_WinFormApps
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.linkLabelForRegistered = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxSignIn = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.checkBoxShowPass = new System.Windows.Forms.CheckBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxSignIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabelForRegistered
            // 
            this.linkLabelForRegistered.AutoSize = true;
            this.linkLabelForRegistered.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelForRegistered.Location = new System.Drawing.Point(374, 406);
            this.linkLabelForRegistered.Name = "linkLabelForRegistered";
            this.linkLabelForRegistered.Size = new System.Drawing.Size(277, 23);
            this.linkLabelForRegistered.TabIndex = 10;
            this.linkLabelForRegistered.TabStop = true;
            this.linkLabelForRegistered.Text = "Not Registered Yet ? Click here";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(64, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 248);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxSignIn
            // 
            this.groupBoxSignIn.Controls.Add(this.btnLogin);
            this.groupBoxSignIn.Controls.Add(this.checkBoxShowPass);
            this.groupBoxSignIn.Controls.Add(this.textBoxPassword);
            this.groupBoxSignIn.Controls.Add(this.textBoxUsername);
            this.groupBoxSignIn.Controls.Add(this.label3);
            this.groupBoxSignIn.Controls.Add(this.label2);
            this.groupBoxSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSignIn.Location = new System.Drawing.Point(341, 106);
            this.groupBoxSignIn.Name = "groupBoxSignIn";
            this.groupBoxSignIn.Size = new System.Drawing.Size(395, 281);
            this.groupBoxSignIn.TabIndex = 8;
            this.groupBoxSignIn.TabStop = false;
            this.groupBoxSignIn.Text = "Sign In";
            // 
            // btnLogin
            // 
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(0, 212);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(363, 58);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // checkBoxShowPass
            // 
            this.checkBoxShowPass.AutoSize = true;
            this.checkBoxShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowPass.Location = new System.Drawing.Point(135, 163);
            this.checkBoxShowPass.Name = "checkBoxShowPass";
            this.checkBoxShowPass.Size = new System.Drawing.Size(149, 24);
            this.checkBoxShowPass.TabIndex = 2;
            this.checkBoxShowPass.Text = "Show password";
            this.checkBoxShowPass.UseVisualStyleBackColor = true;
            this.checkBoxShowPass.CheckedChanged += new System.EventHandler(this.checkBoxShowPass_CheckedChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(134, 112);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(219, 27);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(135, 49);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(219, 27);
            this.textBoxUsername.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Login Form";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabelForRegistered);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxSignIn);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxSignIn.ResumeLayout(false);
            this.groupBoxSignIn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelForRegistered;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxSignIn;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox checkBoxShowPass;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}