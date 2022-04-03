namespace StockLand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.user_signup_button = new System.Windows.Forms.Button();
            this.user_login_button = new System.Windows.Forms.Button();
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
            this.label1.TabIndex = 0;
            this.label1.Text = "StockLand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label2.Location = new System.Drawing.Point(287, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(765, 94);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome to StockLand";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(629, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(406, 43);
            this.label3.TabIndex = 2;
            this.label3.Text = "A Cool Stock Trading Platform";
            // 
            // user_signup_button
            // 
            this.user_signup_button.BackColor = System.Drawing.Color.MediumAquamarine;
            this.user_signup_button.Font = new System.Drawing.Font("Cascadia Code", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_signup_button.Location = new System.Drawing.Point(1056, 452);
            this.user_signup_button.Name = "user_signup_button";
            this.user_signup_button.Size = new System.Drawing.Size(273, 118);
            this.user_signup_button.TabIndex = 3;
            this.user_signup_button.Text = "Get Started Now";
            this.user_signup_button.UseVisualStyleBackColor = false;
            this.user_signup_button.Click += new System.EventHandler(this.user_signup_button_Click);
            // 
            // user_login_button
            // 
            this.user_login_button.BackColor = System.Drawing.Color.IndianRed;
            this.user_login_button.Font = new System.Drawing.Font("Cascadia Code", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_login_button.Location = new System.Drawing.Point(1056, 593);
            this.user_login_button.Name = "user_login_button";
            this.user_login_button.Size = new System.Drawing.Size(273, 55);
            this.user_login_button.TabIndex = 4;
            this.user_login_button.Text = "Already started?";
            this.user_login_button.UseVisualStyleBackColor = false;
            this.user_login_button.Click += new System.EventHandler(this.user_login_button_Click);
            // 
            // admin_login_button
            // 
            this.admin_login_button.BackColor = System.Drawing.Color.DimGray;
            this.admin_login_button.Font = new System.Drawing.Font("Cascadia Code", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_login_button.Location = new System.Drawing.Point(1056, 668);
            this.admin_login_button.Name = "admin_login_button";
            this.admin_login_button.Size = new System.Drawing.Size(273, 55);
            this.admin_login_button.TabIndex = 5;
            this.admin_login_button.Text = "Admin Log In";
            this.admin_login_button.UseVisualStyleBackColor = false;
            this.admin_login_button.Click += new System.EventHandler(this.admin_login_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1400, 899);
            this.Controls.Add(this.admin_login_button);
            this.Controls.Add(this.user_login_button);
            this.Controls.Add(this.user_signup_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button user_signup_button;
        private System.Windows.Forms.Button user_login_button;
        private System.Windows.Forms.Button admin_login_button;
    }
}

