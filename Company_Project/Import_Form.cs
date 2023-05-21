using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company_Project
{
    public partial class Import_Form : Form
    {
        Context context = new Context();
        public Import_Form()
        {
            InitializeComponent();
            var item = context.Imports.OrderByDescending(x => x.ImportCode).FirstOrDefault();
            MessageBox.Show(item.ToString());
            if (item != null)
            {
                code_txt.Text = item.ImportCode.ToString();
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

            var supplierName=from s in context.Suppliers
                             orderby s.SuppName
                             select s;
            supplierName_comboBox2.DropDownStyle= ComboBoxStyle.DropDownList;
            supplierName_comboBox2.DataSource = supplierName.ToList();
            supplierName_comboBox2.DisplayMember = "SuppName";
            supplierName_comboBox2.ValueMember = "SupplierId";


            var storeName=from t in context.Stores
                          orderby t.CompName
                          select t;
            storeName_comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            storeName_comboBox3.DataSource = storeName.ToList();
            storeName_comboBox3.DisplayMember = "CompName";
            storeName_comboBox3.ValueMember = "Id";
        }
       

        private void button1_Click(object sender, EventArgs e)//insert
        {
            try
            {
                string selectedItemFormStore = storeName_comboBox3.SelectedItem.ToString();
                MessageBox.Show(selectedItemFormStore);
                Store store = context.Stores.FirstOrDefault(s => s.CompName == selectedItemFormStore);

                string selectedItemFromSupplier = supplierName_comboBox2.SelectedItem.ToString();
                Suppliers supplier = context.Suppliers.FirstOrDefault(s => s.SuppName == selectedItemFromSupplier);
                if (supplier == null)
                {
                    // Display an error message to the user
                    MessageBox.Show("Selected supplier not found in the database.");

                    // Exit the method or return a default value
                    return;
                }

                string selectedItemFromItem = itemName_comboBox1.SelectedItem.ToString();
                Items item = context.Items.FirstOrDefault(i => i.ItemName == selectedItemFromItem);

                Import_Permission import = new Import_Permission()
                {

                    ImportCode = int.Parse(code_txt.Text),
                    ImportDate = DateTime.Now,
                    ProductionDate = production_date.Value,
                    Expiry = int.Parse(expiry_txt.Text),

                    supplierId = supplier.SupplierID,
                    supplierName = selectedItemFromSupplier,

                    StoreName = selectedItemFormStore,
                    StoreId = store.Id,

                    ItemId = item.Code,
                    ItemsCount = int.Parse(count_txt.Text),

                };
                context.Imports.Add(import);
                context.SaveChanges();

                MessageBox.Show("Import permission added successfully.");
            }
            catch (Exception ex)
            {
                // Handle the exception here. For example, you can display an error message.
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedItemFormStore = storeName_comboBox3.SelectedItem.ToString();
                MessageBox.Show(selectedItemFormStore);
                Store store = context.Stores.FirstOrDefault(s => s.CompName == selectedItemFormStore);

                string selectedItemFromSupplier = supplierName_comboBox2.SelectedItem.ToString();
                Suppliers supplier = context.Suppliers.FirstOrDefault(s => s.SuppName == selectedItemFromSupplier);
                if (supplier == null)
                {
                    // Display an error message to the user
                    MessageBox.Show("Selected supplier not found in the database.");

                    // Exit the method or return a default value
                    return;
                }

                string selectedItemFromItem = itemName_comboBox1.SelectedItem.ToString();
                Items item = context.Items.FirstOrDefault(i => i.ItemName == selectedItemFromItem);

                int importCode = int.Parse(code_txt.Text);

                Import_Permission import = context.Imports.FirstOrDefault(i => i.ImportCode == importCode);
                if (import != null)
                {
                    import.ImportDate = DateTime.Now;
                    import.Expiry = int.Parse(expiry_txt.Text);
                    import.supplierName = selectedItemFromSupplier;
                    import.ProductionDate = production_date.Value;
                    import.StoreName = selectedItemFormStore;
                    import.ItemsCount = int.Parse(count_txt.Text);
                    import.supplierId = supplier.SupplierID;
                    import.ItemId = item.Code;
                    import.StoreId = store.Id;
                    context.SaveChanges();
                    MessageBox.Show("Import was updated");
                }
                else
                {
                    MessageBox.Show("Import not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }


        }
    }
    }

