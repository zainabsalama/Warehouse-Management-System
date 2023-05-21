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
    public partial class Transfer_Form : Form
    {
        Context context=new Context();
        public Transfer_Form()
        {
            InitializeComponent();
            var item = context.Transactions.OrderByDescending(x => x.TransferItemId).FirstOrDefault();
            MessageBox.Show(item.ToString());
            if (item != null)
            {
                id_txt.Text = item.TransferItemId.ToString();
                id_txt.Enabled = true;
            }
            else
            {
                // handle the case where the table is empty
            }

            var Source=from s in context.Stores
                       orderby s.CompName
                       select s;
            sourceStore_comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            sourceStore_comboBox3.DataSource = Source.ToList();
            sourceStore_comboBox3.DisplayMember = "CompName";
            sourceStore_comboBox3.ValueMember = "Id";


           var Destination= from d in context.Stores
                            orderby d.CompName
                            select d;
            disStore_comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            disStore_comboBox2.DataSource = Destination.ToList();
            disStore_comboBox2.DisplayMember = "CompName";
            disStore_comboBox2.ValueMember = "Id";

            var Supplier = from s in context.Suppliers
                              orderby s.SuppName
                              select s;
            SupplierStore_comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            SupplierStore_comboBox4.DataSource = Supplier.ToList();
            SupplierStore_comboBox4.DisplayMember = "SuppName";
            //SupplierStore_comboBox4.ValueMember = "SupplierID ";

            var Items = from i in context.Items
                           orderby i.ItemName
                           select i;
            itemStore_comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            itemStore_comboBox1.DataSource = Items.ToList();
            itemStore_comboBox1.DisplayMember = "ItemName";
            //itemStore_comboBox1.ValueMember = "Code";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedItemFromSorce = sourceStore_comboBox3.SelectedItem.ToString();
            Store store = context.Stores.FirstOrDefault(a => a.CompName == selectedItemFromSorce);

            string selectedItemFromDest=disStore_comboBox2.SelectedItem.ToString();
            Store store2 = context.Stores.FirstOrDefault(a => a.CompName == selectedItemFromDest);

            string selectedItemFromSupplier = SupplierStore_comboBox4.SelectedItem.ToString();
            Suppliers suppliers = context.Suppliers.FirstOrDefault(s => s.SuppName == selectedItemFromSupplier);

            string selectedItemFromItem = itemStore_comboBox1.SelectedItem.ToString();
            Items item=context.Items.FirstOrDefault(i=>i.ItemName== selectedItemFromItem);

            Transfer_Items transfer = new Transfer_Items()
            {
                TransferItemId = int.Parse(id_txt.Text),
                ProductionDate = date.Value,
                Expiry = int.Parse(expiry_txt.Text),
                SourceStore = store.Id,
                DestinationStore= store2.Id,
                SupplierId=suppliers.SupplierID,
                ItemId=item.Code,


            };
            context.Transactions.Add(transfer);
            context.SaveChanges();
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            int inputId = int.Parse(id_txt.Text);
            MessageBox.Show(inputId.ToString());
            var queryResults = from row in context.Transactions
                               where row.TransferItemId== inputId
                               select row;
            

            listBox1.Items.Clear();

            foreach (var row in queryResults)
            {
                string item = $"{row.TransferItemId} - {row.ProductionDate} - {row.Expiry} - {row.SourceStore}- {row.DestinationStore}- {row.SupplierId}- {row.ItemId}";
                listBox1.Items.Add(item);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectedItemFromSorce = sourceStore_comboBox3.SelectedItem.ToString();
            Store store = context.Stores.FirstOrDefault(a => a.CompName == selectedItemFromSorce);

            string selectedItemFromDest = disStore_comboBox2.SelectedItem.ToString();
            Store store2 = context.Stores.FirstOrDefault(a => a.CompName == selectedItemFromDest);

            string selectedItemFromSupplier = SupplierStore_comboBox4.SelectedItem.ToString();
            Suppliers suppliers = context.Suppliers.FirstOrDefault(s => s.SuppName == selectedItemFromSupplier);

            string selectedItemFromItem = itemStore_comboBox1.SelectedItem.ToString();
            Items item = context.Items.FirstOrDefault(i => i.ItemName == selectedItemFromItem);
            int id=int.Parse(id_txt.Text);
            Transfer_Items transfer = context.Transactions.FirstOrDefault(i => i.TransferItemId== id);
            if (transfer != null)
            {
                transfer.SupplierId = suppliers.SupplierID;
                transfer.Expiry = int.Parse(expiry_txt.Text);
                transfer.DestinationStore = store2.Id;
                transfer.SourceStore = store.Id;
                transfer.ItemId = item.Code;
                transfer.ProductionDate = date.Value;
                context.SaveChanges();
            }
        }
    }
}
