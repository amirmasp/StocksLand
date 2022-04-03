namespace StockLand
{
    partial class UserLogInForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.user_signup_button = new System.Windows.Forms.Button();
            this.user_login_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.user_password_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.user_email_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
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
            this.label1.TabIndex = 4;
            this.label1.Text = "StockLand";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.user_signup_button);
            this.groupBox1.Controls.Add(this.user_login_button);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.user_password_textBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.user_email_textBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(173, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 428);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log in to StockLand account";
            // 
            // user_signup_button
            // 
            this.user_signup_button.BackColor = System.Drawing.Color.IndianRed;
            this.user_signup_button.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_signup_button.ForeColor = System.Drawing.Color.Black;
            this.user_signup_button.Location = new System.Drawing.Point(167, 313);
            this.user_signup_button.Name = "user_signup_button";
            this.user_signup_button.Size = new System.Drawing.Size(287, 69);
            this.user_signup_button.TabIndex = 5;
            this.user_signup_button.Text = "Don\'t have an account yet?";
            this.user_signup_button.UseVisualStyleBackColor = false;
            this.user_signup_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // user_login_button
            // 
            this.user_login_button.BackColor = System.Drawing.Color.MediumAquamarine;
            this.user_login_button.Font = new System.Drawing.Font("Cascadia Code", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_login_button.ForeColor = System.Drawing.Color.Black;
            this.user_login_button.Location = new System.Drawing.Point(218, 223);
            this.user_login_button.Name = "user_login_button";
            this.user_login_button.Size = new System.Drawing.Size(183, 70);
            this.user_login_button.TabIndex = 4;
            this.user_login_button.Text = "Log In";
            this.user_login_button.UseVisualStyleBackColor = false;
            this.user_login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password :";
            // 
            // user_password_textBox
            // 
            this.user_password_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_password_textBox.Location = new System.Drawing.Point(167, 143);
            this.user_password_textBox.Name = "user_password_textBox";
            this.user_password_textBox.Size = new System.Drawing.Size(288, 35);
            this.user_password_textBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email :";
            // 
            // user_email_textBox
            // 
            this.user_email_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_email_textBox.Location = new System.Drawing.Point(166, 69);
            this.user_email_textBox.Name = "user_email_textBox";
            this.user_email_textBox.Size = new System.Drawing.Size(288, 35);
            this.user_email_textBox.TabIndex = 0;
            
            // 
            // UserLogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "UserLogInForm";
            this.Text = "UserLogInForm";
            this.Load += new System.EventHandler(this.UserLogInForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button user_signup_button;
        private System.Windows.Forms.Button user_login_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox user_password_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user_email_textBox;
    }
}