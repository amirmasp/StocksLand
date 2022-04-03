namespace StockLand
{
    partial class AdminLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.admin_username_textBox = new System.Windows.Forms.TextBox();
            this.admin_password_textBox = new System.Windows.Forms.TextBox();
            this.admin_login_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mistral", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "StockLand";
            // 
            // admin_username_textBox
            // 
            this.admin_username_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_username_textBox.Location = new System.Drawing.Point(140, 95);
            this.admin_username_textBox.Name = "admin_username_textBox";
            this.admin_username_textBox.Size = new System.Drawing.Size(253, 39);
            this.admin_username_textBox.TabIndex = 2;
            this.admin_username_textBox.Text = "username";
            this.admin_username_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // admin_password_textBox
            // 
            this.admin_password_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_password_textBox.Location = new System.Drawing.Point(140, 155);
            this.admin_password_textBox.Name = "admin_password_textBox";
            this.admin_password_textBox.Size = new System.Drawing.Size(253, 39);
            this.admin_password_textBox.TabIndex = 3;
            this.admin_password_textBox.Text = "password";
            this.admin_password_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // admin_login_button
            // 
            this.admin_login_button.BackColor = System.Drawing.Color.MediumAquamarine;
            this.admin_login_button.Font = new System.Drawing.Font("Cascadia Code", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_login_button.Location = new System.Drawing.Point(184, 209);
            this.admin_login_button.Name = "admin_login_button";
            this.admin_login_button.Size = new System.Drawing.Size(152, 88);
            this.admin_login_button.TabIndex = 4;
            this.admin_login_button.Text = "Log In";
            this.admin_login_button.UseVisualStyleBackColor = false;
            this.admin_login_button.Click += new System.EventHandler(this.admin_login_button_Click);
            // 
            // AdminLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(611, 535);
            this.Controls.Add(this.admin_login_button);
            this.Controls.Add(this.admin_password_textBox);
            this.Controls.Add(this.admin_username_textBox);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "AdminLoginForm";
            this.Text = "AdminLoginForm";
            this.Load += new System.EventHandler(this.AdminLoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox admin_username_textBox;
        private System.Windows.Forms.TextBox admin_password_textBox;
        private System.Windows.Forms.Button admin_login_button;
    }
}