namespace StockLand
{
    partial class UserMainForm
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
            this.components = new System.ComponentModel.Container();
            this.companiesDataGridView = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.log_out_button = new System.Windows.Forms.Button();
            this.home_page_button = new System.Windows.Forms.Button();
            this.cash_account_button = new System.Windows.Forms.Button();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.balance_screenBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.buy_market_price_button = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.review_buy_market_button = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.radio_button_groupBox = new System.Windows.Forms.GroupBox();
            this.buy_market_radioButton = new System.Windows.Forms.RadioButton();
            this.buy_limit_radioButton = new System.Windows.Forms.RadioButton();
            this.label24 = new System.Windows.Forms.Label();
            this.limit_buy_price_textBox = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.welcome_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.limit_sell_price_textBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.sell_limit_radioButton = new System.Windows.Forms.RadioButton();
            this.sell_market_radioButton = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.review_sell_market_button = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.sell_button = new System.Windows.Forms.Button();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.companiesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.radio_button_groupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // companiesDataGridView
            // 
            this.companiesDataGridView.AllowUserToAddRows = false;
            this.companiesDataGridView.AllowUserToDeleteRows = false;
            this.companiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companiesDataGridView.Location = new System.Drawing.Point(12, 50);
            this.companiesDataGridView.Name = "companiesDataGridView";
            this.companiesDataGridView.ReadOnly = true;
            this.companiesDataGridView.RowHeadersWidth = 62;
            this.companiesDataGridView.RowTemplate.Height = 28;
            this.companiesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.companiesDataGridView.Size = new System.Drawing.Size(822, 487);
            this.companiesDataGridView.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Open Hour:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(401, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 30);
            this.textBox1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Open Day:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(235, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 30);
            this.textBox2.TabIndex = 7;
            // 
            // log_out_button
            // 
            this.log_out_button.BackColor = System.Drawing.Color.IndianRed;
            this.log_out_button.Font = new System.Drawing.Font("Cascadia Code", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_out_button.Location = new System.Drawing.Point(1214, 0);
            this.log_out_button.Name = "log_out_button";
            this.log_out_button.Size = new System.Drawing.Size(178, 83);
            this.log_out_button.TabIndex = 13;
            this.log_out_button.Text = "Log Out";
            this.log_out_button.UseVisualStyleBackColor = false;
            this.log_out_button.Click += new System.EventHandler(this.log_out_button_Click);
            // 
            // home_page_button
            // 
            this.home_page_button.BackColor = System.Drawing.Color.MediumAquamarine;
            this.home_page_button.Font = new System.Drawing.Font("Cascadia Code", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_page_button.Location = new System.Drawing.Point(1030, 0);
            this.home_page_button.Name = "home_page_button";
            this.home_page_button.Size = new System.Drawing.Size(178, 83);
            this.home_page_button.TabIndex = 14;
            this.home_page_button.Text = "Home Page";
            this.home_page_button.UseVisualStyleBackColor = false;
            this.home_page_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // cash_account_button
            // 
            this.cash_account_button.BackColor = System.Drawing.Color.PowderBlue;
            this.cash_account_button.Font = new System.Drawing.Font("Cascadia Code", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash_account_button.Location = new System.Drawing.Point(846, 0);
            this.cash_account_button.Name = "cash_account_button";
            this.cash_account_button.Size = new System.Drawing.Size(178, 83);
            this.cash_account_button.TabIndex = 15;
            this.cash_account_button.Text = "Cash account ";
            this.cash_account_button.UseVisualStyleBackColor = false;
            this.cash_account_button.Click += new System.EventHandler(this.cash_account_button_Click);
            // 
            // userDataGridView
            // 
            this.userDataGridView.AllowUserToAddRows = false;
            this.userDataGridView.AllowUserToDeleteRows = false;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Location = new System.Drawing.Point(12, 591);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.ReadOnly = true;
            this.userDataGridView.RowHeadersWidth = 62;
            this.userDataGridView.RowTemplate.Height = 28;
            this.userDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userDataGridView.Size = new System.Drawing.Size(822, 446);
            this.userDataGridView.TabIndex = 16;
            this.userDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userDataGridView_CellContentClick);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Highlight;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(822, 38);
            this.label8.TabIndex = 18;
            this.label8.Text = "Stocks";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.Highlight;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(12, 550);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(822, 38);
            this.label9.TabIndex = 19;
            this.label9.Text = "Your Stocks";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(846, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(552, 129);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Market Schedule";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(14, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // balance_screenBox
            // 
            this.balance_screenBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance_screenBox.Location = new System.Drawing.Point(396, 19);
            this.balance_screenBox.Name = "balance_screenBox";
            this.balance_screenBox.Size = new System.Drawing.Size(145, 30);
            this.balance_screenBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "$";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.limit_buy_price_textBox);
            this.groupBox3.Controls.Add(this.radio_button_groupBox);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.review_buy_market_button);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.buy_market_price_button);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(14, 55);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(532, 363);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buy ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(279, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Shares :";
            this.label7.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(93, 230);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(145, 30);
            this.textBox4.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Buy :";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(93, 29);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(145, 30);
            this.textBox3.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Price :";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(381, 137);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(145, 30);
            this.textBox5.TabIndex = 16;
            this.textBox5.Visible = false;
            // 
            // buy_market_price_button
            // 
            this.buy_market_price_button.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buy_market_price_button.Location = new System.Drawing.Point(381, 298);
            this.buy_market_price_button.Name = "buy_market_price_button";
            this.buy_market_price_button.Size = new System.Drawing.Size(123, 59);
            this.buy_market_price_button.TabIndex = 2;
            this.buy_market_price_button.Text = "Buy ";
            this.buy_market_price_button.UseVisualStyleBackColor = false;
            this.buy_market_price_button.Click += new System.EventHandler(this.Buy_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(69, 35);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(18, 20);
            this.label19.TabIndex = 18;
            this.label19.Text = "$";
            // 
            // review_buy_market_button
            // 
            this.review_buy_market_button.BackColor = System.Drawing.Color.PowderBlue;
            this.review_buy_market_button.Location = new System.Drawing.Point(381, 179);
            this.review_buy_market_button.Name = "review_buy_market_button";
            this.review_buy_market_button.Size = new System.Drawing.Size(123, 58);
            this.review_buy_market_button.TabIndex = 19;
            this.review_buy_market_button.Text = "Review Order";
            this.review_buy_market_button.UseVisualStyleBackColor = false;
            this.review_buy_market_button.Click += new System.EventHandler(this.review_buy_market_button_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(1, 137);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(86, 20);
            this.label27.TabIndex = 24;
            this.label27.Text = "Opening$";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(93, 130);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(145, 30);
            this.textBox6.TabIndex = 27;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(93, 79);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(145, 30);
            this.textBox8.TabIndex = 29;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(14, 86);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 20);
            this.label20.TabIndex = 28;
            this.label20.Text = "High :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(69, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 20);
            this.label12.TabIndex = 30;
            this.label12.Text = "$";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 31;
            this.label11.Text = "Low :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(69, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "$";
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(255, 250);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(280, 45);
            this.label23.TabIndex = 20;
            this.label23.Text = "label23";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label23.Visible = false;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(93, 179);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(145, 30);
            this.textBox7.TabIndex = 33;
            // 
            // radio_button_groupBox
            // 
            this.radio_button_groupBox.Controls.Add(this.label24);
            this.radio_button_groupBox.Controls.Add(this.buy_limit_radioButton);
            this.radio_button_groupBox.Controls.Add(this.buy_market_radioButton);
            this.radio_button_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_button_groupBox.Location = new System.Drawing.Point(254, 0);
            this.radio_button_groupBox.Name = "radio_button_groupBox";
            this.radio_button_groupBox.Size = new System.Drawing.Size(276, 76);
            this.radio_button_groupBox.TabIndex = 19;
            this.radio_button_groupBox.TabStop = false;
            // 
            // buy_market_radioButton
            // 
            this.buy_market_radioButton.AutoSize = true;
            this.buy_market_radioButton.Location = new System.Drawing.Point(137, 15);
            this.buy_market_radioButton.Name = "buy_market_radioButton";
            this.buy_market_radioButton.Size = new System.Drawing.Size(83, 24);
            this.buy_market_radioButton.TabIndex = 35;
            this.buy_market_radioButton.TabStop = true;
            this.buy_market_radioButton.Text = "Market";
            this.buy_market_radioButton.UseVisualStyleBackColor = true;
            this.buy_market_radioButton.CheckedChanged += new System.EventHandler(this.buy_market_radioButton_CheckedChanged);
            // 
            // buy_limit_radioButton
            // 
            this.buy_limit_radioButton.AutoSize = true;
            this.buy_limit_radioButton.Location = new System.Drawing.Point(137, 45);
            this.buy_limit_radioButton.Name = "buy_limit_radioButton";
            this.buy_limit_radioButton.Size = new System.Drawing.Size(67, 24);
            this.buy_limit_radioButton.TabIndex = 34;
            this.buy_limit_radioButton.TabStop = true;
            this.buy_limit_radioButton.Text = "Limit";
            this.buy_limit_radioButton.UseVisualStyleBackColor = true;
            this.buy_limit_radioButton.CheckedChanged += new System.EventHandler(this.buy_limit_radioButton_CheckedChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(23, 29);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(102, 20);
            this.label24.TabIndex = 36;
            this.label24.Text = "Order Type:";
            // 
            // limit_buy_price_textBox
            // 
            this.limit_buy_price_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limit_buy_price_textBox.Location = new System.Drawing.Point(382, 92);
            this.limit_buy_price_textBox.Name = "limit_buy_price_textBox";
            this.limit_buy_price_textBox.Size = new System.Drawing.Size(145, 30);
            this.limit_buy_price_textBox.TabIndex = 38;
            this.limit_buy_price_textBox.Visible = false;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(259, 99);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(97, 20);
            this.label29.TabIndex = 39;
            this.label29.Text = "Limit Price:";
            this.label29.Visible = false;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(361, 99);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(18, 20);
            this.label30.TabIndex = 40;
            this.label30.Text = "$";
            this.label30.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(290, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Balance:";
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.ForeColor = System.Drawing.Color.Green;
            this.welcome_label.Location = new System.Drawing.Point(15, 26);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(66, 20);
            this.welcome_label.TabIndex = 6;
            this.welcome_label.Text = "Welcom";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.welcome_label);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.balance_screenBox);
            this.groupBox1.Location = new System.Drawing.Point(840, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 801);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Account";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.limit_sell_price_textBox);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.review_sell_market_button);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.sell_button);
            this.groupBox4.Controls.Add(this.textBox13);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.textBox14);
            this.groupBox4.Controls.Add(this.label31);
            this.groupBox4.Controls.Add(this.textBox15);
            this.groupBox4.Controls.Add(this.label32);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox4.Location = new System.Drawing.Point(9, 424);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(532, 371);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sell";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(361, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 20);
            this.label13.TabIndex = 40;
            this.label13.Text = "$";
            this.label13.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(259, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 20);
            this.label14.TabIndex = 39;
            this.label14.Text = "Limit Price:";
            this.label14.Visible = false;
            // 
            // limit_sell_price_textBox
            // 
            this.limit_sell_price_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limit_sell_price_textBox.Location = new System.Drawing.Point(382, 92);
            this.limit_sell_price_textBox.Name = "limit_sell_price_textBox";
            this.limit_sell_price_textBox.Size = new System.Drawing.Size(145, 30);
            this.limit_sell_price_textBox.TabIndex = 38;
            this.limit_sell_price_textBox.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.sell_limit_radioButton);
            this.groupBox5.Controls.Add(this.sell_market_radioButton);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(254, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(276, 76);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(23, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 20);
            this.label15.TabIndex = 36;
            this.label15.Text = "Order Type:";
            // 
            // sell_limit_radioButton
            // 
            this.sell_limit_radioButton.AutoSize = true;
            this.sell_limit_radioButton.Location = new System.Drawing.Point(137, 45);
            this.sell_limit_radioButton.Name = "sell_limit_radioButton";
            this.sell_limit_radioButton.Size = new System.Drawing.Size(67, 24);
            this.sell_limit_radioButton.TabIndex = 34;
            this.sell_limit_radioButton.TabStop = true;
            this.sell_limit_radioButton.Text = "Limit";
            this.sell_limit_radioButton.UseVisualStyleBackColor = true;
            this.sell_limit_radioButton.CheckedChanged += new System.EventHandler(this.sell_limit_radioButton_CheckedChanged);
            // 
            // sell_market_radioButton
            // 
            this.sell_market_radioButton.AutoSize = true;
            this.sell_market_radioButton.Location = new System.Drawing.Point(137, 15);
            this.sell_market_radioButton.Name = "sell_market_radioButton";
            this.sell_market_radioButton.Size = new System.Drawing.Size(83, 24);
            this.sell_market_radioButton.TabIndex = 35;
            this.sell_market_radioButton.TabStop = true;
            this.sell_market_radioButton.Text = "Market";
            this.sell_market_radioButton.UseVisualStyleBackColor = true;
            this.sell_market_radioButton.CheckedChanged += new System.EventHandler(this.sell_market_radioButton_CheckedChanged);
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(255, 250);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(280, 45);
            this.label16.TabIndex = 20;
            this.label16.Text = "label16";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label16.Visible = false;
            // 
            // review_sell_market_button
            // 
            this.review_sell_market_button.BackColor = System.Drawing.Color.PowderBlue;
            this.review_sell_market_button.Location = new System.Drawing.Point(381, 179);
            this.review_sell_market_button.Name = "review_sell_market_button";
            this.review_sell_market_button.Size = new System.Drawing.Size(123, 58);
            this.review_sell_market_button.TabIndex = 19;
            this.review_sell_market_button.Text = "Review Order";
            this.review_sell_market_button.UseVisualStyleBackColor = false;
            this.review_sell_market_button.Click += new System.EventHandler(this.review_sell_market_button_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(74, 198);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(18, 20);
            this.label26.TabIndex = 18;
            this.label26.Text = "$";
            // 
            // sell_button
            // 
            this.sell_button.BackColor = System.Drawing.Color.IndianRed;
            this.sell_button.Location = new System.Drawing.Point(381, 298);
            this.sell_button.Name = "sell_button";
            this.sell_button.Size = new System.Drawing.Size(123, 59);
            this.sell_button.TabIndex = 2;
            this.sell_button.Text = "Sell";
            this.sell_button.UseVisualStyleBackColor = false;
            this.sell_button.Click += new System.EventHandler(this.sell_button_Click);
            // 
            // textBox13
            // 
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(381, 137);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(145, 30);
            this.textBox13.TabIndex = 16;
            this.textBox13.Visible = false;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(13, 198);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(59, 20);
            this.label28.TabIndex = 11;
            this.label28.Text = "Price :";
            // 
            // textBox14
            // 
            this.textBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.Location = new System.Drawing.Point(98, 191);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(145, 30);
            this.textBox14.TabIndex = 12;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(29, 144);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(49, 20);
            this.label31.TabIndex = 13;
            this.label31.Text = "Buy :";
            // 
            // textBox15
            // 
            this.textBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox15.Location = new System.Drawing.Point(98, 137);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(145, 30);
            this.textBox15.TabIndex = 14;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(279, 140);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(76, 20);
            this.label32.TabIndex = 15;
            this.label32.Text = "Shares :";
            this.label32.Visible = false;
            // 
            // UserMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1401, 1060);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.userDataGridView);
            this.Controls.Add(this.cash_account_button);
            this.Controls.Add(this.home_page_button);
            this.Controls.Add(this.log_out_button);
            this.Controls.Add(this.companiesDataGridView);
            this.Name = "UserMainForm";
            this.Text = "UserMainForm";
            this.Load += new System.EventHandler(this.UserMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companiesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.radio_button_groupBox.ResumeLayout(false);
            this.radio_button_groupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tickerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView companiesDataGridView;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button log_out_button;
        private System.Windows.Forms.Button home_page_button;
        private System.Windows.Forms.Button cash_account_button;
        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox balance_screenBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox limit_buy_price_textBox;
        private System.Windows.Forms.GroupBox radio_button_groupBox;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.RadioButton buy_limit_radioButton;
        private System.Windows.Forms.RadioButton buy_market_radioButton;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button review_buy_market_button;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button buy_market_price_button;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox limit_sell_price_textBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton sell_limit_radioButton;
        private System.Windows.Forms.RadioButton sell_market_radioButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button review_sell_market_button;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button sell_button;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label32;
    }
}