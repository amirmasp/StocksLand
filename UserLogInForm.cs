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
    public partial class UserLogInForm : Form
    {
        TradingContext db;
        private static string userEmailBuffer = "";
        private static string userPasswordBuffer = "";
        public UserLogInForm()
        {
            InitializeComponent();
        }
        // Static method to return static fields
        public static string UserEmailBuffer() { return userEmailBuffer; }
        public static string UserPasswordBuffer() { return userPasswordBuffer; }
        public static void ResetBuffers()
        {
            userEmailBuffer = "";
            userPasswordBuffer = "";
        }

        // The signUp page button
        private void button1_Click(object sender, EventArgs e)
        {
            UserSignUpForm signUpForm = new UserSignUpForm();
            this.Close();
            this.Hide();
            signUpForm.ShowDialog();
        }

        // Load form event
        private void UserLogInForm_Load(object sender, EventArgs e)
        {
            // After loading first check buffers are not empty, if they are not,
            // then closes the login form and open user main form because user is still
            // loged in 
            if (!string.IsNullOrEmpty(userEmailBuffer) && !string.IsNullOrEmpty(userPasswordBuffer))
            {
                this.Close();
                this.Hide();
                UserMainForm userMainForm = new UserMainForm(); 
                userMainForm.ShowDialog();
            }
        }

        // Log in event handler
        private void login_button_Click(object sender, EventArgs e)
        {   //TODO: Add some logic to this event if user puts wrong email or password
            db = new TradingContext();// Open a sesssion to the generated database from my edmx
            if (!string.IsNullOrEmpty(user_email_textBox.Text) && !string.IsNullOrEmpty(user_password_textBox.Text))
            {   
                 
                // query to find the given user data from database
                var query = from user in db.Users
                            where user.Email == user_email_textBox.Text && user.Password == user_password_textBox.Text
                            select user;
                if (query.Count() == 0)
                {
                    MessageBox.Show("Wrong email address or password!");
                }
                else
                {
                    // query object is Inumerabal so we can iterate over it with foreach
                    foreach (var user in query)
                    {
                        if (user.Email == user_email_textBox.Text && user.Password == user_password_textBox.Text)
                        {
                            // if user is authorized then fill out buffers that will be accessed from UserMainForm
                            userEmailBuffer = user.Email;
                            userPasswordBuffer = user.Password;
                            UserMainForm userMainForm = new UserMainForm();

                            this.Close();
                            this.Hide();
                            userMainForm.ShowDialog();


                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter your email and password");
            }
        }  
    }
}
