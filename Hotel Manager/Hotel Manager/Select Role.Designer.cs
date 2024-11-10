namespace Hotel_Manager
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radGuest = new System.Windows.Forms.RadioButton();
            this.radManager = new System.Windows.Forms.RadioButton();
            this.radEmployee = new System.Windows.Forms.RadioButton();
            this.bnContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(39, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(768, 113);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome to Boutique Hotel Management System";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(62, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(723, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please select your role";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // radGuest
            // 
            this.radGuest.BackColor = System.Drawing.Color.SaddleBrown;
            this.radGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGuest.Location = new System.Drawing.Point(301, 547);
            this.radGuest.Name = "radGuest";
            this.radGuest.Size = new System.Drawing.Size(244, 37);
            this.radGuest.TabIndex = 2;
            this.radGuest.TabStop = true;
            this.radGuest.Text = "Guest";
            this.radGuest.UseVisualStyleBackColor = false;
            // 
            // radManager
            // 
            this.radManager.BackColor = System.Drawing.Color.SaddleBrown;
            this.radManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radManager.Location = new System.Drawing.Point(301, 653);
            this.radManager.Name = "radManager";
            this.radManager.Size = new System.Drawing.Size(244, 41);
            this.radManager.TabIndex = 4;
            this.radManager.TabStop = true;
            this.radManager.Text = "Manager";
            this.radManager.UseVisualStyleBackColor = false;
            // 
            // radEmployee
            // 
            this.radEmployee.BackColor = System.Drawing.Color.SaddleBrown;
            this.radEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEmployee.Location = new System.Drawing.Point(301, 763);
            this.radEmployee.Name = "radEmployee";
            this.radEmployee.Size = new System.Drawing.Size(244, 37);
            this.radEmployee.TabIndex = 3;
            this.radEmployee.TabStop = true;
            this.radEmployee.Text = "Employee";
            this.radEmployee.UseVisualStyleBackColor = false;
            // 
            // bnContinue
            // 
            this.bnContinue.AutoSize = true;
            this.bnContinue.BackColor = System.Drawing.Color.PapayaWhip;
            this.bnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnContinue.ForeColor = System.Drawing.Color.Black;
            this.bnContinue.Location = new System.Drawing.Point(324, 878);
            this.bnContinue.Name = "bnContinue";
            this.bnContinue.Size = new System.Drawing.Size(198, 56);
            this.bnContinue.TabIndex = 5;
            this.bnContinue.Text = "Continue";
            this.bnContinue.UseVisualStyleBackColor = false;
            this.bnContinue.Click += new System.EventHandler(this.bnContinue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hotel_Manager.Properties.Resources._38620e7003911424fde272aec5a763b9;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(849, 1100);
            this.Controls.Add(this.bnContinue);
            this.Controls.Add(this.radManager);
            this.Controls.Add(this.radEmployee);
            this.Controls.Add(this.radGuest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radGuest;
        private System.Windows.Forms.RadioButton radManager;
        private System.Windows.Forms.RadioButton radEmployee;
        private System.Windows.Forms.Button bnContinue;
    }
}

