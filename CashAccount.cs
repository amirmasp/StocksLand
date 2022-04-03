using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockLand
{

    public partial class CashAccount : Form
    {
        TradingContext db;
        private static string userEmailBuffer = "";
        private static string userPasswordBuffer = "";
        // static methods returns static buffers and resets them
        public static string UserPasswordBuffer() { return userPasswordBuffer; }
        public static string UserEmailBuffer() { return userEmailBuffer; }
        public static void ResetBuffers()
        {
            userEmailBuffer = "";
            userPasswordBuffer = "";
        }
        public CashAccount()
        {
            InitializeComponent();
            db = new TradingContext();
        }

        // Page load handler
        private void CashAccount_Load(object sender, EventArgs e)
        {
            // First checks the buffers of UserMainForm  with calling static methods
            userEmailBuffer = UserMainForm.UserEmailBuffer();
            userPasswordBuffer = UserMainForm.UserPasswordBuffer();

            // Starting a session
            // using causes a session gets open and and after } closes the connection
            using (db = new TradingContext())
            {
                var query = from user in db.Users
                            where user.Email == userEmailBuffer && user.Password == userPasswordBuffer
                            select user;
                if (query.Count() == 0)
                {
                    MessageBox.Show("OOPS,username and password in the UserMainForm is not valid!");
                }
                else
                {
                    foreach (var user in query)
                    {
                        cash_account_number_screenBox.Text = Convert.ToString(user.CashAccountNumber);
                        balance_screenBox.Text = Convert.ToString(user.Balance);
                        transactionDataGridView.DataSource = db.Transactions.Where(a => a.UserId == user.Id).ToList();// Display user transactions
                    }
                }
            }
            // Ending a seesion
            transactionDataGridView.Columns["Id"].Visible = false;
            transactionDataGridView.Columns["UserId"].Visible = false;
            transactionDataGridView.Columns["User"].Visible = false;
        }


        private void make_withdrawl_button_Click(object sender, EventArgs e)
        {
            // TODO: The withdrawl amount has to be sent to user debit card number

            var withdrawlAmount = Convert.ToDecimal(dep_wit_amount_textBox.Text);
            // Open a seesion
            using (db = new TradingContext())
            {
                var query = from user in db.Users
                            where user.Email == userEmailBuffer && user.Password == userPasswordBuffer
                            select user;
                foreach (var user in query)
                {   
                    if (user.Balance > withdrawlAmount)
                    {
                        user.Balance -= withdrawlAmount; // update database
                        balance_screenBox.Text = Convert.ToString(user.Balance);// update screen
                        //TODO: transfer to user debit card
                        
                        message_label.Text = $"You have withdrew ${dep_wit_amount_textBox.Text} from your account!";
                        message_label.Visible = true;
                        dep_wit_amount_textBox.Text = "";
                    }
                    else
                    {
                        message_label.Text = "Your current balance is less than your Rquest amount!";
                        message_label.Visible = true;
                        dep_wit_amount_textBox.Text = "";

                    }

                }
                db.SaveChanges();
            }
            // The session ends
        }

        private void make_deposit_button_Click(object sender, EventArgs e)
        {
            //TODO: Update Model with int? DebitNumber property which is assigned to user with first deposit

            var depositAmount = Convert.ToDecimal(dep_wit_amount_textBox.Text);

            // Open a seesion
            using (db = new TradingContext())
            {
                var query = from user in db.Users
                            where user.Email == userEmailBuffer && user.Password == userPasswordBuffer
                            select user;
                foreach (var user in query)
                {
                    user.Balance += depositAmount;// update database
                    balance_screenBox.Text = Convert.ToString(user.Balance);// update page balance screenBox
                    
                }
                db.SaveChanges();
            }
            // The session ends
            message_label.Text = $"You have deposited amount ${dep_wit_amount_textBox.Text} to your account!";
            message_label.Visible = true;
            dep_wit_amount_textBox.Text = "";
        }

    }
    
}
