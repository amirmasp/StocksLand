using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace StockLand
{
    public partial class UserMainForm : Form
    {
        // Fields
        TradingContext db;
        private static string userEmailBuffer = "";
        private static string userPasswordBuffer = "";
        private int ticks = 0;
        private bool isOpenDay = false;
        private bool isOpenHour = false;
        private static List<decimal> initialPriceList;
        private static List<decimal> highestPriceList;
        private static List<decimal> lowestPriceList;
        private bool maxFlag = false;
        private int companiesNumber;
        //TODO: Put these orderLimit stuff in a struct
        private decimal buyOrder1LimitPrice;
        private decimal buyOrder1LimitShares;
        private int buyOrder1LimitRowIndex;
        private bool buyOrderPriceIsReached = false;
        private bool orderIsExecuted = false;

        // Constructor
        public UserMainForm()
        {
            InitializeComponent();
            timer1.Start();
            initialPriceList = new List<decimal>();
            highestPriceList = new List<decimal>();
            lowestPriceList = new List<decimal>();
            db = new TradingContext();
        }

        // Some static methods to accesss private static fiels
        public static string UserPasswordBuffer() { return userPasswordBuffer; }
        public static string UserEmailBuffer() { return userEmailBuffer; }
        public static void ResetBuffers()
        {
            userEmailBuffer = "";
            userPasswordBuffer = "";
        }
        public static List<decimal> InitialPriceList()
        {
            return initialPriceList;
        }
        public static void ResetInitiaPriceList()
        {
            initialPriceList.Clear();
        }
        public static void ResetHighestPriceList()
        {
            highestPriceList.Clear();
        }
        public static void ResetLowestPriceList()
        {
            lowestPriceList.Clear();
        }

        // Form load event handler
        private void UserMainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.Companies' table. You can move, or remove it, as needed.
            //this.companiesTableAdapter.Fill(this.dataSet2.Companies);
            
            //companiesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //companiesDataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //Fill out companies data into DataGridView
            companiesDataGridView.DataSource = db.Companies.Where(c => c.UserId == 0).ToList();
            companiesDataGridView.Columns["Id"].Visible = false;
            companiesDataGridView.Columns["UserId"].Visible = false;
            companiesDataGridView.Columns["User"].Visible = false;

            //var job = db.Jobs.Include(x => x.Quotes.Select(q => q.QuoteItems)).Where(x => x.JobID == id).SingleOrDefault();
            // return DatabaseContext.Applications .Include(a => a.Children.Select(c => c.ChildRelationshipType));
            // var query = db.Users.Where(c => c.Email == userEmailBuffer).Include("Companies").ToList;
            //userDataGridView.DataSource = query;

            // Copy the UserLoginForm static variabless into its own buffer, user has already authorized
            userEmailBuffer = UserLogInForm.UserEmailBuffer();
            userPasswordBuffer = UserLogInForm.UserPasswordBuffer();

            //get the user Id, create a session to database
            using (db = new TradingContext()) {
                var userIdQuery = from user in db.Users
                                  where user.Email == userEmailBuffer && user.Password == userPasswordBuffer
                                  select user;
                foreach (var user in userIdQuery)
                {
                    // Fill out userDataGridView with the user's own stocks
                    userDataGridView.DataSource = db.Companies.Where(a => a.UserId == user.Id ).ToList();
                    // && a.Shares > 0
                }
            }
            userDataGridView.Columns["Id"].Visible = false;
            userDataGridView.Columns["UserId"].Visible = false;
            userDataGridView.Columns["User"].Visible = false;
            //userDataGridView.Columns["Volume"].Visible = false;


            //Fill out the initialPriceList with opening prices
            // and  initializes highest and lowest prices list
            ResetInitiaPriceList();
            ResetHighestPriceList();
            ResetHighestPriceList();
            for (int i = 0; i < companiesDataGridView.Rows.Count; i++)
            {
                initialPriceList.Add(Convert.ToDecimal(companiesDataGridView.Rows[i].Cells[3].Value));
                highestPriceList.Add(Convert.ToDecimal(companiesDataGridView.Rows[i].Cells[3].Value));
                lowestPriceList.Add(Convert.ToDecimal(companiesDataGridView.Rows[i].Cells[3].Value));

            }
            
            // Check the current hour see market is open?
            if (AdminMainForm.StartTime() <= Convert.ToInt16(DateTime.Now.Hour) &&
                Convert.ToInt16(DateTime.Now.Hour) <= AdminMainForm.EndTime())
            {
                isOpenHour = true;
            }

            // Check the current day to see market is open?
            var currentDay = DateTime.Now.DayOfWeek.ToString();// what day is today?
            var listOfDays = AdminMainForm.CheckMarketSchedule();
            foreach (string day in listOfDays)
            {
                if (day == currentDay)
                {
                    isOpenDay = true;
                }
            }
            
            // Welcom to user and show the balance
            using (var db = new TradingContext())
            {   
                var balanceQuery = from user in db.Users
                                   where user.Email == userEmailBuffer && user.Password == userPasswordBuffer
                                   select user;
                if (balanceQuery.Count() > 0)
                {
                    foreach (User user in balanceQuery)
                    {
                        balance_screenBox.Text = Convert.ToString(user.Balance);
                        welcome_label.Text = $"Welcome back {user.FullName}!";
                        welcome_label.Visible = true;
                    }
                }
            } 
        }

        // Back to home page handler w/o log out    
        private void home_button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
        }

        // Back to home page with Log out 
        private void log_out_button_Click(object sender, EventArgs e)
        {
            // Reset buffers in all related forms
            userEmailBuffer = "";
            userPasswordBuffer = "";
            UserLogInForm.ResetBuffers();
            CashAccount.ResetBuffers();
            this.Close();
            this.Hide();
        }

        
        // Random Stock Price Generator
        private void PseudoPriceGenerator(int row)
        {   
            // Prices will gradually  go up.
            // After hitting max price, prices go down to hit min price and again ...
            // This function is called if market is open.
            decimal currentPrice = Convert.ToDecimal(companiesDataGridView.Rows[row].Cells[3].Value);
            decimal initialPrice = initialPriceList[row];
            Random random = new Random();
            double doubleRandom = random.NextDouble() / 1; // Can speed up/low the price changes
            decimal maxPrice = initialPrice + (initialPrice / 10);
            decimal minPrice = initialPrice - (initialPrice / 10);

            if (currentPrice < maxPrice && !maxFlag)
            {
                currentPrice += Convert.ToDecimal(doubleRandom);
                currentPrice = Math.Round(currentPrice, 2);
                companiesDataGridView.Rows[row].Cells[3].Value = currentPrice;
                if (currentPrice >= maxPrice)
                {
                    maxFlag = true;
                }
            }
            if (currentPrice > minPrice && maxFlag)
            {
                currentPrice -= Convert.ToDecimal(doubleRandom);
                currentPrice = Math.Round(currentPrice, 2);
                companiesDataGridView.Rows[row].Cells[3].Value = currentPrice;
                if (currentPrice <= minPrice)
                {
                    maxFlag = false;
                }
            }
        }

        // Buy Limit order function which is called from timer
        // whenever flag buyOrderPriceIsReached turns to true
        private void BuyLimitOrder()
        {
            // Create a Transaction
            Transaction transaction = new Transaction();
            transaction.TradeTime = DateTime.Now;
            transaction.Price = buyOrder1LimitPrice;
            transaction.Shares = buyOrder1LimitShares;

            // Creating a new stock  for customer
            var stock = new Company();
            stock.Name = companiesDataGridView.Rows[buyOrder1LimitRowIndex].Cells[1].Value.ToString();
            stock.Ticker = companiesDataGridView.Rows[buyOrder1LimitRowIndex].Cells[2].Value.ToString();
            stock.Shares = buyOrder1LimitShares;
            stock.Price = buyOrder1LimitPrice;

            // Compute the price that user has to pay
            decimal tradeAmount = buyOrder1LimitShares * buyOrder1LimitPrice;

            // Add volume of shares purchased by the user to the company volume
            // and update the total shares of thecompany
            using (db = new TradingContext())
            {
                var companyQuery = from company in db.Companies
                                   where company.Name == stock.Name && company.Ticker == stock.Ticker
                                   select company;
                foreach (var company in companyQuery)
                {   // add purchased shares to the volume of that comany
                    company.Volume += buyOrder1LimitShares;
                    company.Shares -= buyOrder1LimitShares;
                    transaction.Seller = company.Name;

                }
                db.SaveChanges();
            }
            // Add purchased stock by user to its Companies collection Dbset
            using (db = new TradingContext())
            {
                var userQuery = from user in db.Users
                                where user.Email == userEmailBuffer && user.Password == userPasswordBuffer
                                select user;
                foreach (var user in userQuery)
                {
                    stock.UserId = user.Id;// Assign the stock's UserId with its owner's UserId 
                    user.Companies.Add(stock);
                    user.Balance -= tradeAmount; // Update User Balance
                    transaction.Buyer = user.FullName;
                    transaction.UserId = user.Id; // Assign the transaction's UserId with its owner's UserId 
                    user.Transactions.Add(transaction);
                }
                db.SaveChanges();
            }
            MessageBox.Show("Your stock successfuly added to your account!");
            // Reset order buffers
            orderIsExecuted = true;
            

        }

        //  Buy button event handler
        private void Buy_Click(object sender, EventArgs e)

        {   // If Market is open 
            if (isOpenDay && isOpenHour)
            {   // if Market option was chosen
                if (buy_market_radioButton.Checked)
                { 
                    // Create a Transaction
                    Transaction transaction = new Transaction();
                    transaction.TradeTime = DateTime.Now;
                    transaction.Price = Convert.ToDecimal(companiesDataGridView.SelectedRows[0].Cells[3].Value);
                    transaction.Shares = Convert.ToDecimal(textBox5.Text);

                    // Creating a new stock  for customer
                    var stock = new Company();
                    stock.Name = companiesDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                    stock.Ticker = companiesDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                    stock.Shares = Convert.ToDecimal(textBox5.Text); // shares customer pays for
                    stock.Price = Convert.ToDecimal(companiesDataGridView.SelectedRows[0].Cells[3].Value);

                    // Compute the price that user has to pay
                    decimal tradeAmount = Convert.ToDecimal(stock.Shares) * Convert.ToDecimal(stock.Price);

                    // Add volume of shares purchased by the user to the company volume
                    // and update the total shares of thecompany
                    using (db = new TradingContext())
                    {
                        var companyQuery = from company in db.Companies
                                       where company.Name == stock.Name && company.Ticker == stock.Ticker
                                       select company;
                        foreach (var company in companyQuery)
                        {   // add purchased shares to the volume of that comany
                            company.Volume += Convert.ToDecimal(stock.Shares);
                            company.Shares -= Convert.ToDecimal(stock.Shares);
                            transaction.Seller = company.Name;
                        }
                        db.SaveChanges();
                    }
                    // Add purchased stock by user to its Companies collection Dbset
                    using (db = new TradingContext())
                    {
                        var userQuery = from user in db.Users
                                    where user.Email == userEmailBuffer && user.Password == userPasswordBuffer
                                    select user;
                        foreach (var user in userQuery)
                        {
                            stock.UserId = user.Id;// Assign the stock's UserId with its owner's UserId 
                            user.Companies.Add(stock);
                            user.Balance -= tradeAmount; // Update User Balance
                            transaction.Buyer = user.FullName;
                            transaction.UserId = user.Id; // Assign the transaction's UserId with its owner's UserId 
                            user.Transactions.Add(transaction);
                        }
                        db.SaveChanges();
                    }
                    MessageBox.Show("Your stock successfuly added to your account!");
                }
                else
                { // if Limit Order was chosen here only puts the corresponding data to buffers

                    buyOrder1LimitPrice = Convert.ToDecimal(limit_buy_price_textBox.Text);
                    buyOrder1LimitShares = Convert.ToDecimal(textBox5.Text);
                    buyOrder1LimitRowIndex = companiesDataGridView.CurrentCell.RowIndex; // Getting the selected row index
                    MessageBox.Show("Your Limit price order is processed!");
                    orderIsExecuted = false;
                }
            }
            else
            {
                MessageBox.Show("Sorry! Market is closed in your area. Please check OpenHour and OpenDay labels.");
            }
            
        }

        // Timer event, occurs every second, 1000 ticks
        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            if (isOpenDay && isOpenHour) // Check market is open then allow the stock prices to fluctuate 
            {
                companiesNumber = companiesDataGridView.Rows.Count; // How many records are there?
                Random random = new Random();
                int x = random.Next() % companiesNumber; // pick a record at random each second
                if (random.Next() % 1 == 0) // Just to do some delay
                {
                    PseudoPriceGenerator(x);
                }
            }

            // Finding High, Low, and opening prices for current price in any given second on Buy group
            if (companiesDataGridView.Rows.Count > 0)
            {
                Decimal currentPrice = Convert.ToDecimal(companiesDataGridView.SelectedRows[0].Cells[3].Value);
                var idx = companiesDataGridView.CurrentCell.RowIndex; // Getting the selected row index
                Decimal openingPrice = Convert.ToDecimal(initialPriceList[idx]);
                textBox3.Text = companiesDataGridView.SelectedRows[0].Cells[3].Value.ToString(); // The current price
                textBox4.Text = companiesDataGridView.SelectedRows[0].Cells[2].Value.ToString(); // The ticker
                textBox6.Text = openingPrice.ToString();// The opening price           
                if (currentPrice >= highestPriceList[idx])
                {
                    highestPriceList[idx] = currentPrice;// Update high price
                }
                if (currentPrice <= lowestPriceList[idx])
                {
                    lowestPriceList[idx] = currentPrice;// Update low price
                }
                textBox7.Text = lowestPriceList[idx].ToString(); // The lowest price so far
                textBox8.Text = highestPriceList[idx].ToString(); // The highest price so far
            }

            // Finding selected row update price in sell group
            if (userDataGridView.Rows.Count > 0)
            {
                string selectedStockTicker = userDataGridView.SelectedRows[0].Cells[2].Value.ToString(); // Get the ticker
                int rowIndex = 0;
                foreach (DataGridViewRow row in companiesDataGridView.Rows)
                {
                    if (row.Cells[2].Value.ToString().Equals(selectedStockTicker))
                    {
                        rowIndex = row.Index;// This is the index of corresponding stock in Stocks record table
                        break;
                    }
                }
                decimal currentPriceSell = Convert.ToDecimal(companiesDataGridView.Rows[rowIndex].Cells[3].Value);
                textBox14.Text = currentPriceSell.ToString(); // The update price
                textBox15.Text = selectedStockTicker;
            }


            // Check out market availability
            if (!isOpenHour)
            {
                textBox2.Text = "No";
            }
            else
            {
                textBox2.Text = "Yes";
            }

            if (!isOpenDay)
            {
                textBox1.Text = "No";
            }
            else
            {
                textBox1.Text = "Yes";
            }

            // Checks  persistently if the current price in buyOrder1LimitRowIndex is
            // reached to customer limit buy price order, then turns a flag on and calls a function
            if(Convert.ToDecimal(companiesDataGridView.Rows[buyOrder1LimitRowIndex].Cells[3].Value) <= buyOrder1LimitPrice &&
                !buyOrderPriceIsReached && !orderIsExecuted) // orderIsExecuted shows previous order 
            {
                buyOrderPriceIsReached = true;
                BuyLimitOrder();
                MessageBox.Show("Order will be executed soon!Boom");               
            }
        }

        // Go to Cash account page
        private void cash_account_button_Click(object sender, EventArgs e)
        {
            CashAccount account = new CashAccount();
            account.ShowDialog();
        }

        private void userDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // label13.Text = $"Limit order, so add a text box instead of this";
            //label13.Visible = true;
        }

      
        // if Market was chosen as option, This is a checked event and consistently is checked like timer event
        private void buy_market_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            label30.Visible = false;
            label29.Visible = false;
            limit_buy_price_textBox.Visible = false;
            label7.Visible = true;
            textBox5.Visible = true;

        }
        //if limit option was chosen, This is a checked event and consistently is checked like timer event
        private void buy_limit_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            label30.Visible = true;
            label29.Visible = true;
            limit_buy_price_textBox.Visible = true;
            label7.Visible = true;
            textBox5.Visible = true;
            
        }

        // Review total price before buy event
        private void review_buy_market_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox5.Text))
            {
                // A local variable to hold shares
                var shares = Convert.ToDecimal(textBox5.Text);
                var priceMarket = Convert.ToDecimal(textBox3.Text);
                //decimal priceLimit = Convert.ToDecimal(limit_buy_price_textBox.Text);

                if (buy_limit_radioButton.Checked)
                {
                    label23.Text = $"  Total : {Convert.ToDecimal(limit_buy_price_textBox.Text)} *" +
                        $" {Convert.ToDecimal(textBox5.Text)} = ${Convert.ToDecimal(limit_buy_price_textBox.Text) * Convert.ToDecimal(textBox5.Text)}";
                    label23.Visible = true;
                }
                else
                {
                    label23.Text = $"Total is {Convert.ToDecimal(textBox3.Text)} * " +
                        $"{Convert.ToDecimal(textBox5.Text)} = ${priceMarket * Convert.ToDecimal(textBox5.Text)}";
                    label23.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Please Enter Shares!");
            }
        }

        // When Sell market radio option is cheked
        private void sell_market_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            label13.Visible = false;
            label14.Visible = false;
            limit_sell_price_textBox.Visible = false;
            label32.Visible = true;
            textBox13.Visible = true;
        }

        // When Sell limit radio option is checked
        private void sell_limit_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            label13.Visible = true;
            label14.Visible = true;
            limit_sell_price_textBox.Visible = true;
            label32.Visible = true;
            textBox13.Visible = true;
        }

        // Review total price before sell event
        private void review_sell_market_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox13.Text))
            {
                var priceMarket = Convert.ToDecimal(textBox14.Text);
                if (sell_limit_radioButton.Checked)
                {
                    label16.Text = $"  Total : {Convert.ToDecimal(limit_sell_price_textBox.Text)} *" +
                        $" {Convert.ToDecimal(textBox13.Text)} = ${Convert.ToDecimal(limit_sell_price_textBox.Text) * Convert.ToDecimal(textBox13.Text)}";
                    label16.Visible = true;
                }
                else
                {
                    label16.Text = $"Total is {Convert.ToDecimal(textBox14.Text)} * " +
                        $"{Convert.ToDecimal(textBox13.Text)} = ${priceMarket * Convert.ToDecimal(textBox13.Text)}";
                    label16.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Please Enter Shares!");
            }
        }
        
        // Market Sell order
        private void sell_button_Click(object sender, EventArgs e)
        {
            // If Market is open 
            if (isOpenDay && isOpenHour)
            {   // if Market option was chosen
                if (sell_market_radioButton.Checked)
                {
                    MessageBox.Show("TODO:ADD Sell Market Order Functionality.");/*
                    // check the chosen stock share is acceptable for sell
                    if (Convert.ToDecimal(textBox13.Text) > Convert.ToDecimal(userDataGridView.SelectedRows[0].Cells[5].Value))// Shares are in column 5
                    {
                        //MessageBox.Show($"Your current share for this record is less than {textBox13.Text}");
                        MessageBox.Show($"You have {Convert.ToDecimal(userDataGridView.SelectedRows[0].Cells[5].Value)} shares for this record");
                    }
                    else // Process sell market order
                    {
                        string stockName = userDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                        string stockTicker = userDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                        decimal stockShares = Convert.ToDecimal(userDataGridView.SelectedRows[0].Cells[5].Value);
                        // Create a Transaction
                        Transaction transaction = new Transaction();
                        transaction.TradeTime = DateTime.Now;
                        //transaction.Price = Convert.ToDecimal(textBox14.Text);
                        transaction.Shares = Convert.ToDecimal(textBox13.Text);

                        // Compute the price that user has to pay
                        decimal tradeAmount = Convert.ToDecimal(textBox13.Text) * Convert.ToDecimal(textBox14.Text);

                        // Subtract the user share from company volume and add to total shares of company
                        using (db = new TradingContext())
                        {
                            var companyQuery = from company in db.Companies
                                               where company.Name == stockName && company.Ticker == stockTicker
                                               select company;
                            foreach (var company in companyQuery)
                            {   // update company 
                                //company.Volume -= Convert.ToDecimal(stockShares);
                                company.Shares += Convert.ToDecimal(stockShares);
                                transaction.Buyer = company.Name;
                            }
                            db.SaveChanges();
                        }
                        // Update the user balance 
                        //TODO: Update user stock
                        using (db = new TradingContext())
                        {
                            var userQuery = from user in db.Users
                                            where user.Email == userEmailBuffer && user.Password == userPasswordBuffer
                                            select user;
                            foreach(var user in db.Users)
                            {
                                user.Balance += tradeAmount; // Update User Balance
                                transaction.Seller = user.FullName;
                                transaction.UserId = user.Id; // Assign the transaction's UserId with its owner's UserId 
                                transaction.Price = tradeAmount;
                                user.Transactions.Add(transaction);
                            }
                            db.SaveChanges();
                        }
                        //var idx = userDataGridView.CurrentCell.RowIndex; // Getting the selected row index
                        //userDataGridView.Rows.RemoveAt(idx); // Remove the record from userDataGridView
                        //todo: still we need to update record in database1
                        //MessageBox.Show("The sell transaction added to your history!");
                    }*/

                }
                else// Limit order
                {
                    MessageBox.Show("TODO:ADD Sell Limit Order Functionality.");
                }
            }
            else
            {
                MessageBox.Show("Sorry! Market is closed in your area. Please check OpenHour and OpenDay labels.");
            }
        }
        

        //#####################################################################################
        /* TODO: Comment out
        // Tick event handler, interval 1000 = 1s
        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;

            if (isOpenDay && isOpenHour) // Check market is open then allow the stock prices to fluctuate 
            {
                companiesNumber = StocksDataGridView.Rows.Count; // How many records are there?
                Random random = new Random();
                int x = random.Next() % companiesNumber; // pick a record at random each second
                if (random.Next() % 2 == 0) // some delay
                {
                    //PseudoPriceGenerator(x);
                }
            }
           

            if (!isOpenHour)
            {
                textBox2.Text = "No";
            }
            else
            {
                textBox2.Text = "Yes";
            }

            if (!isOpenDay)
            {
                textBox1.Text = "No";
            }
            else
            {
                textBox1.Text = "Yes";
            }
        }*/

        // cash account buttom handler


        // selecting from stocks event
        /* private void companiesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {
             var stockSelected = companiesDataGridView.SelectedRows[0].Cells[0].Value.ToString();
             stock_screenBox.Text = stockSelected;
             label_market_price.Text = $"${StocksDataGridView.SelectedRows[0].Cells[2].Value}";
             label_market_price.Visible.ToString();

         }*/


    }
}
