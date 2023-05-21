using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company_Project
{
    public partial class Customers_Form : Form
    {
        Context context=new Context();
        public Customers_Form()
        {
            InitializeComponent();
            var item = context.Customers.OrderByDescending(x => x.CustomId).FirstOrDefault();
            MessageBox.Show(item.ToString());
            if (item != null)
            {
                id_txt.Text = item.CustomId.ToString();
                id_txt.Enabled = true;
            }
            else
            {
                // handle the case where the table is empty
            }
        }

        private void Customers_Form_Load(object sender, EventArgs e)
        {

        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Customers customers = new Customers()
                {
                    CustomId = int.Parse(id_txt.Text),
                    CustomName = name_txt.Text,
                    Customphone = int.Parse(phone_txt.Text),
                    CustomEmail = email_txt.Text,
                    CustomFax = fax_txt.Text,
                    CustomWebsite = site_txt.Text,
                };
                context.Customers.Add(customers);
                context.SaveChanges();

                MessageBox.Show("Customer inserted successfully.");
            }
            catch (Exception ex)
            {
                // Handle the exception here. For example, you can display an error message.
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(id_txt.Text);
                Customers customers = context.Customers.FirstOrDefault(c => c.CustomId == id);
                if (customers != null)
                {
                    customers.CustomName = name_txt.Text;
                    customers.Customphone = int.Parse(phone_txt.Text);
                    customers.CustomFax = fax_txt.Text;
                    customers.CustomEmail = email_txt.Text;
                    customers.CustomWebsite = site_txt.Text;
                    context.SaveChanges();
                    MessageBox.Show("Customer updated successfully.");
                }
                else
                {
                    MessageBox.Show("Customer not found.");
                }
            }
            catch (Exception ex)
            {
                // Handle the exception here. For example, you can display an error message.
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
