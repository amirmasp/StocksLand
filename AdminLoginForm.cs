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
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void admin_login_button_Click(object sender, EventArgs e)
        {
            // Create a session context to database
            TradingContext db = new TradingContext();

            // Check admin enters its username and password in textBoxes
            if (admin_username_textBox.Text != "" || admin_password_textBox.Text != "")
            {
                // create a query to check if admin is authorized to access
                var query = from admin in db.Admins
                            where admin.Username == admin_username_textBox.Text
                            select admin;
                if (query.Count() > 0)
                {   
                    foreach (var admin in query)
                    {
                        if (admin.Password == admin_password_textBox.Text)
                        {
                            AdminMainForm adminMainForm = new AdminMainForm();
                            this.Close();
                            this.Hide();
                            adminMainForm.ShowDialog();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Admin is not authorized in server. Please contact StockLand support team!");
                }
            }
            else
            {
                MessageBox.Show("Please Enter username and password, then Log In again!");     
            }   
        }

        private void AdminLoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
