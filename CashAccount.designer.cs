namespace StockLand
{
    partial class CashAccount
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.make_withdrawl_button = new System.Windows.Forms.Button();
            this.make_deposit_button = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.debit_card_number_textBox = new System.Windows.Forms.TextBox();
            this.message_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dep_wit_amount_textBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.balance_screenBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cash_account_number_screenBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.transactionDataGridView = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(840, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 873);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cash Account";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.debit_card_number_textBox);
            this.groupBox3.Controls.Add(this.message_label);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dep_wit_amount_textBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(24, 261);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(575, 544);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.make_withdrawl_button);
            this.groupBox4.Controls.Add(this.make_deposit_button);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(20, 257);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(508, 191);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            // 
            // make_withdrawl_button
            // 
            this.make_withdrawl_button.BackColor = System.Drawing.Color.IndianRed;
            this.make_withdrawl_button.Font = new System.Drawing.Font("Cascadia Code", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.make_withdrawl_button.ForeColor = System.Drawing.Color.Black;
            this.make_withdrawl_button.Location = new System.Drawing.Point(288, 25);
            this.make_withdrawl_button.Name = "make_withdrawl_button";
            this.make_withdrawl_button.Size = new System.Drawing.Size(214, 136);
            this.make_withdrawl_button.TabIndex = 9;
            this.make_withdrawl_button.Text = "Withdrawl Cash";
            this.make_withdrawl_button.UseVisualStyleBackColor = false;
            this.make_withdrawl_button.Click += new System.EventHandler(this.make_withdrawl_button_Click);
            // 
            // make_deposit_button
            // 
            this.make_deposit_button.BackColor = System.Drawing.Color.MediumAquamarine;
            this.make_deposit_button.Font = new System.Drawing.Font("Cascadia Code", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.make_deposit_button.ForeColor = System.Drawing.Color.Black;
            this.make_deposit_button.Location = new System.Drawing.Point(6, 25);
            this.make_deposit_button.Name = "make_deposit_button";
            this.make_deposit_button.Size = new System.Drawing.Size(214, 136);
            this.make_deposit_button.TabIndex = 8;
            this.make_deposit_button.Text = "Deposit Cash";
            this.make_deposit_button.UseVisualStyleBackColor = false;
            this.make_deposit_button.Click += new System.EventHandler(this.make_deposit_button_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(16, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(525, 47);
            this.label10.TabIndex = 13;
            this.label10.Text = "How Much Do You Deposit/Withdraw?";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(16, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(525, 47);
            this.label4.TabIndex = 4;
            this.label4.Text = "Please Enter a 16 digits Debit Card Number Properly";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // debit_card_number_textBox
            // 
            this.debit_card_number_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debit_card_number_textBox.Location = new System.Drawing.Point(223, 82);
            this.debit_card_number_textBox.Name = "debit_card_number_textBox";
            this.debit_card_number_textBox.Size = new System.Drawing.Size(222, 44);
            this.debit_card_number_textBox.TabIndex = 5;
            // 
            // message_label
            // 
            this.message_label.AutoSize = true;
            this.message_label.BackColor = System.Drawing.Color.Transparent;
            this.message_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.message_label.Location = new System.Drawing.Point(6, 473);
            this.message_label.Name = "message_label";
            this.message_label.Size = new System.Drawing.Size(64, 25);
            this.message_label.TabIndex = 12;
            this.message_label.Text = "label8";
            this.message_label.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(196, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "$";
            // 
            // dep_wit_amount_textBox
            // 
            this.dep_wit_amount_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dep_wit_amount_textBox.Location = new System.Drawing.Point(223, 207);
            this.dep_wit_amount_textBox.Name = "dep_wit_amount_textBox";
            this.dep_wit_amount_textBox.Size = new System.Drawing.Size(222, 44);
            this.dep_wit_amount_textBox.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.balance_screenBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cash_account_number_screenBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(64, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 191);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(156, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 29);
            this.label9.TabIndex = 11;
            this.label9.Text = "#";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Balance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(156, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "$";
            // 
            // balance_screenBox
            // 
            this.balance_screenBox.AllowDrop = true;
            this.balance_screenBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance_screenBox.Location = new System.Drawing.Point(183, 121);
            this.balance_screenBox.Name = "balance_screenBox";
            this.balance_screenBox.ReadOnly = true;
            this.balance_screenBox.Size = new System.Drawing.Size(222, 44);
            this.balance_screenBox.TabIndex = 3;
            this.balance_screenBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Account";
            // 
            // cash_account_number_screenBox
            // 
            this.cash_account_number_screenBox.AllowDrop = true;
            this.cash_account_number_screenBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash_account_number_screenBox.Location = new System.Drawing.Point(183, 31);
            this.cash_account_number_screenBox.Name = "cash_account_number_screenBox";
            this.cash_account_number_screenBox.ReadOnly = true;
            this.cash_account_number_screenBox.Size = new System.Drawing.Size(222, 44);
            this.cash_account_number_screenBox.TabIndex = 1;
            this.cash_account_number_screenBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cash_account_number_screenBox.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mistral", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(570, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "StockLand";
            // 
            // transactionDataGridView
            // 
            this.transactionDataGridView.AllowUserToAddRows = false;
            this.transactionDataGridView.AllowUserToDeleteRows = false;
            this.transactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionDataGridView.Location = new System.Drawing.Point(3, 73);
            this.transactionDataGridView.Name = "transactionDataGridView";
            this.transactionDataGridView.ReadOnly = true;
            this.transactionDataGridView.RowHeadersWidth = 62;
            this.transactionDataGridView.RowTemplate.Height = 28;
            this.transactionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transactionDataGridView.Size = new System.Drawing.Size(831, 809);
            this.transactionDataGridView.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Highlight;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(3, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(831, 61);
            this.label8.TabIndex = 18;
            this.label8.Text = "Transaction Records";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CashAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1469, 884);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.transactionDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CashAccount";
            this.Text = "CashAccount";
            this.Load += new System.EventHandler(this.CashAccount_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button make_withdrawl_button;
        private System.Windows.Forms.Button make_deposit_button;
        private System.Windows.Forms.TextBox dep_wit_amount_textBox;
        private System.Windows.Forms.TextBox debit_card_number_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox balance_screenBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cash_account_number_screenBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label message_label;
        private System.Windows.Forms.DataGridView transactionDataGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}