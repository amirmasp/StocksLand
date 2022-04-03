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
    public partial class UserSignUpForm : Form
    {   // use a context instance per form. This lets you use change-tracking functionality that context provides.
        TradingContext db;
        // This static variable will be reset with each new run time of application.
        private static int accountNumberSeed = 123456789; // To assign a unique account number to each user
        public UserSignUpForm()
        {
            InitializeComponent();
        }
        public static int AccountNumberSeed() { return accountNumberSeed; }
        public static void AccountNumberSeedSet(int newSeed) { accountNumberSeed = newSeed; }

        private void user_signup__button_Click(object sender, EventArgs e)
        {
            db = new TradingContext();

            if (!string.IsNullOrEmpty(user_email_textBox.Text)
                && !string.IsNullOrEmpty(user_fullname_textBox.Text)
                && !string.IsNullOrEmpty(user_password_textBox.Text))
            {
                var query = from user in db.Users
                            where user.Email == user_email_textBox.Text
                            select user; ;
                if (query.Count() > 0)
                {
                    MessageBox.Show("The email address is already registered in StockLand!");
                }
                if (user_password_textBox.Text.Length < 8)
                {   
                    MessageBox.Show("The password must be at least 8 characters!");   
                }
                else
                {
                    
                    User user = new User();
                    user.FullName = user_fullname_textBox.Text;
                    user.Email = user_email_textBox.Text;
                    //TODO: Save password hash instead of text in database
                    user.Password = user_password_textBox.Text;
                    user.Balance = 0;
                    user.CashAccountNumber = accountNumberSeed;
                    accountNumberSeed++;
                    
                    db.Users.Add(user);
                    db.SaveChanges();
                    MessageBox.Show("Congrats! You are in now. Please go to log in page and log in to your account.");
                    this.Close();
                    this.Hide();

                    //TODO: user has to directed to user login page after successfuly sign up
                    UserLogInForm  userLogInForm = new UserLogInForm();
                    userLogInForm.ShowDialog();

                }
            }
            else
            {
                MessageBox.Show("Please Complete all sections in the form!");
            }
        }

        private void UserSignUpForm_Load(object sender, EventArgs e)
        {

        }
    }
}
