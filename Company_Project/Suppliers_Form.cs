using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company_Project
{
    public partial class Suppliers_Form : Form
    {
        Context context = new Context();
        public Suppliers_Form()
        {
            InitializeComponent();
            var item = context.Suppliers.OrderByDescending(x => x.SupplierID).FirstOrDefault();
            MessageBox.Show(item.ToString());
            if (item != null)
            {
                id_txt.Text = item.SupplierID.ToString();
                id_txt.Enabled = true;
            }
            else
            {
                // handle the case where the table is empty
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Suppliers suppliers = new Suppliers()
                {
                    SupplierID = int.Parse(id_txt.Text),
                    SuppName = name_txt.Text,
                    Suppphone = int.Parse(phone_txt.Text),
                    SuppEmail = email_txt.Text,
                    SuppFax = fax_txt.Text,
                    SuppWebsite = site_txt.Text,
                };
                context.Suppliers.Add(suppliers);
                context.SaveChanges();

                MessageBox.Show("Supplier inserted successfully.");
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
                Suppliers suppliers = context.Suppliers.FirstOrDefault(a => a.SupplierID == id);
                if (suppliers != null)
                {
                    suppliers.SuppName = name_txt.Text;
                    suppliers.Suppphone = int.Parse(phone_txt.Text);
                    suppliers.SuppFax = fax_txt.Text;
                    suppliers.SuppEmail = email_txt.Text;
                    suppliers.SuppWebsite = site_txt.Text;
                    context.SaveChanges();
                    MessageBox.Show("Supplier updated successfully.");
                }
                else
                {
                    MessageBox.Show("Suppliers not found.");
                }
            }
            catch (Exception ex)
            {
                // Handle the exception here. For example, you can display an error message.
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void fax_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void site_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void name_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
