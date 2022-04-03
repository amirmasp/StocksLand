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
    public partial class AdminMainForm : Form
    {
        TradingContext db;
        private static List<string> listDays = new List<string>();
        private static int startTime;
        private static int endTime;
        public AdminMainForm()
        {
            InitializeComponent();
            
        }
        public static int StartTime() { return startTime; }
        public static int EndTime() { return endTime; }
        public static List<string> CheckMarketSchedule() { return listDays; }
        private void AdminMainForm_Load(object sender, EventArgs e)
        {

        }

        private void add_newstock_button_Click(object sender, EventArgs e)
        {
            //db = new TradingContext();

            // Checking all textBoxes are entered
            if (company_name_textBox.Text != "" && price_textBox.Text != "" && ticker_textBox.Text != "" 
                &&  total_shares_textBox.Text != "" && volume_textBox.Text !="")
            {
                using (db = new TradingContext())
                {
                    Company company = new Company();
                    company.Name = company_name_textBox.Text;
                    // Price is going to be decimal so convert string to decimal before storing in database
                    // Later in UserMainForm we have to coner it back from decimal string to show it to user as text
                    company.Price = Convert.ToDecimal(price_textBox.Text);
                    company.Shares = Convert.ToDecimal(total_shares_textBox.Text);
                    company.Ticker = ticker_textBox.Text;
                    company.Volume = Convert.ToDecimal(volume_textBox.Text);
                    company.UserId = Convert.ToInt32(userid_textBox.Text);
                    db.Companies.Add(company);
                    db.SaveChanges();
                    MessageBox.Show("Stock added to database");
                }
            }
            else
            {
                MessageBox.Show("Please Complete Form before adding stock!");
            }
        }

        // Adding a method to reset form. This method can be called on reset event
        private void ResetForm()
        {
            company_name_textBox.Text = "";
            ticker_textBox.Text = "";
            total_shares_textBox.Text = "";
            volume_textBox.Text = "";
            price_textBox.Text = "";
        }

        private void reset_form_button_Click(object sender, EventArgs e)
        {
            ResetForm();
            
        }

        private void schedule_button_Click(object sender, EventArgs e)
        {   //TODO: find some smarter way if you have time
            listDays.Clear();
            
            if (monday_checkBox.Checked)
            {
                listDays.Add("Monday");
            }
            if (tuesday_checkBox.Checked)
            {
                listDays.Add("Tuesday");
            }
            if (wednesday_checkBox.Checked)
            {
                listDays.Add("Wednesday");
            }
            if (thursday_checkBox.Checked)
            {
                listDays.Add("Thursday");
            }
            if (friday_checkBox.Checked)
            {
                listDays.Add("Friday");
            }
            if (saturday_checkBox.Checked)
            {
                listDays.Add("Saturday");
            }
            if (sunday_checkBox.Checked)
            {
                listDays.Add("Sunday");
            }
            MessageBox.Show("All limitation is added to market schedule!");
            
        }

        private void change_hours_button_Click(object sender, EventArgs e)
        {
            startTime = Convert.ToInt16(start_time_textBox.Text);
            endTime = Convert.ToInt16(end_time_textBox.Text);
            MessageBox.Show("Done! You set the hours!");
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
        }
    }
}
