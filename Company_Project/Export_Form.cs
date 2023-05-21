using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Company_Project
{
    public partial class Export_Form : Form
    {
        Context context = new Context();
        public Export_Form()
        {
            InitializeComponent();

            var item = context.Exports.OrderByDescending(x => x.ExportCode).FirstOrDefault();
            MessageBox.Show(item.ToString());
            if (item != null)
            {
                code_txt.Text = item.ExportCode.ToString();
            code_txt.Enabled = true;
        }
            else
            {
                // handle the case where the table is empty
            }
            var itemName = from i in context.Items
                           orderby i.ItemName
                           select i;
            itemName_comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            itemName_comboBox1.DataSource = itemName.ToList();
            itemName_comboBox1.DisplayMember = "ItemName";
            itemName_comboBox1.ValueMember = "Code";

            var supplierName = from s in context.Customers
                               orderby s.CustomName
                               select s;
            customerName_comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            customerName_comboBox2.DataSource = supplierName.ToList();
            customerName_comboBox2.DisplayMember = "CustomName";
            customerName_comboBox2.ValueMember = "CustomId";


            var storeName = from t in context.Stores
                            orderby t.CompName
                            select t;
            storeName_comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            storeName_comboBox3.DataSource = storeName.ToList();
            storeName_comboBox3.DisplayMember = "CompName";
            storeName_comboBox3.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedItemFormStore = storeName_comboBox3.SelectedItem.ToString();
                MessageBox.Show(selectedItemFormStore);
                Store store = context.Stores.FirstOrDefault(s => s.CompName == selectedItemFormStore);

                string selectedItemFromCustomer = customerName_comboBox2.SelectedItem.ToString();
                Customers customers = context.Customers.FirstOrDefault(s => s.CustomName == selectedItemFromCustomer);
                if (customers == null)
                {
                    // Display an error message to the user
                    MessageBox.Show("Selected Customer not found in the database.");

                    // Exit the method or return a default value
                    return;
                }

                string selectedItemFromItem = itemName_comboBox1.SelectedItem.ToString();
                Items item = context.Items.FirstOrDefault(i => i.ItemName == selectedItemFromItem);

                Export_Permission export = new Export_Permission()
                {

                    ExportCode = int.Parse(code_txt.Text),
                    ExportDate = DateTime.Now,
                    //ProductionDate = production_date.Value,
                    // Expiry = int.Parse(expiry_txt.Text),


                    StoreName = selectedItemFormStore,
                    StoreId = store.Id,

                    ItemId = item.Code,
                    ItemsCount = int.Parse(count_txt.Text),

                    customerId = customers.CustomId,
                    customerName = selectedItemFromCustomer,
                };
                context.Exports.Add(export);
                context.SaveChanges();
                MessageBox.Show("Export permission created successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while creating export permission: " + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedItemFormStore = storeName_comboBox3.SelectedItem.ToString();
                MessageBox.Show(selectedItemFormStore);
                Store store = context.Stores.FirstOrDefault(s => s.CompName == selectedItemFormStore);

                string selectedItemFromCustomer = customerName_comboBox2.SelectedItem.ToString();
                Customers customers = context.Customers.FirstOrDefault(s => s.CustomName == selectedItemFromCustomer);
                if (customers == null)
                {
                    // Display an error message to the user
                    MessageBox.Show("Selected Customer not found in the database.");

                    // Exit the method or return a default value
                    return;
                }

                string selectedItemFromItem = itemName_comboBox1.SelectedItem.ToString();
                Items item = context.Items.FirstOrDefault(i => i.ItemName == selectedItemFromItem);
                int exportCode = int.Parse(code_txt.Text);

                Export_Permission export = context.Exports.FirstOrDefault(i => i.ExportCode == exportCode);
                if (export != null)
                {
                    export.ExportDate = DateTime.Now;
                    //export.Expiry = int.Parse(expiry_txt.Text);
                    export.customerName = selectedItemFromCustomer;
                    //export.ProductionDate = production_date.Value;
                    export.StoreName = selectedItemFormStore;
                    export.ItemsCount = int.Parse(count_txt.Text);
                    export.customerId = customers.CustomId;
                    export.ItemId = item.Code;
                    export.StoreId = store.Id;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }
    

        private void Export_Form_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
