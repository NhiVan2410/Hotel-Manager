namespace Hotel_Manager
{
    partial class Login
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
            this.goupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.goupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // goupBox1
            // 
            this.goupBox1.AutoSize = true;
            this.goupBox1.BackColor = System.Drawing.Color.Transparent;
            this.goupBox1.Controls.Add(this.pictureBox2);
            this.goupBox1.Controls.Add(this.pictureBox1);
            this.goupBox1.Controls.Add(this.btnLogin);
            this.goupBox1.Controls.Add(this.chkShowPassword);
            this.goupBox1.Controls.Add(this.txtPassWord);
            this.goupBox1.Controls.Add(this.txtUserName);
            this.goupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goupBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.goupBox1.Location = new System.Drawing.Point(179, 132);
            this.goupBox1.Name = "goupBox1";
            this.goupBox1.Size = new System.Drawing.Size(393, 392);
            this.goupBox1.TabIndex = 0;
            this.goupBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Crimson;
            this.btnLogin.Location = new System.Drawing.Point(130, 321);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(115, 37);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LOGIN ";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chkShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkShowPassword.Location = new System.Drawing.Point(117, 241);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(148, 24);
            this.chkShowPassword.TabIndex = 2;
            this.chkShowPassword.Text = "Show Password";
            this.chkShowPassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.chkShowPassword.UseVisualStyleBackColor = false;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUserName.Location = new System.Drawing.Point(69, 85);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(234, 35);
            this.txtUserName.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Hotel_Manager.Properties.Resources.pngtree_user_icon_png_image_5097430;
            this.pictureBox1.Location = new System.Drawing.Point(17, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox2.Image = global::Hotel_Manager.Properties.Resources.login_password_3;
            this.pictureBox2.Location = new System.Drawing.Point(17, 163);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // txtPassWord
            // 
            this.txtPassWord.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassWord.Location = new System.Drawing.Point(69, 163);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPassWord.Size = new System.Drawing.Size(234, 35);
            this.txtPassWord.TabIndex = 2;
            this.txtPassWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(221, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Boutique Hotel ";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hotel_Manager.Properties.Resources._231feb406f7d58c7cc18cd2c9f786026;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 617);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.goupBox1.ResumeLayout(false);
            this.goupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox goupBox1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label label1;
    }
}