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
    public partial class Form1 : Form

    {   
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void admin_login_button_Click(object sender, EventArgs e)
        {
            //CashAccount cashAccount = new CashAccount();
            
            AdminLoginForm adminLoginForm = new AdminLoginForm();   
            adminLoginForm.ShowDialog();
        }

        private void user_signup_button_Click(object sender, EventArgs e)
        {
            UserSignUpForm userSignUpForm = new UserSignUpForm();
            userSignUpForm.ShowDialog();
            

        }

        private void user_login_button_Click(object sender, EventArgs e)
        {
            UserLogInForm userLogInForm = new UserLogInForm();  
            userLogInForm.ShowDialog();
        }
    }
}
