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
    public partial class Items_Form : Form
    {
        Context context=new Context();
        public Items_Form()
        {
            InitializeComponent();
            
            var stores = from d in context.Stores
                         orderby d.Id
                         select d;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DataSource = stores.ToList();
            comboBox1.DisplayMember = "Id";
            comboBox1.ValueMember = "Id";
            comboBox1.Refresh();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void insert_btn_Click(object sender, EventArgs e)
        {

            try
            {
                Items items = new Items()
                {
                    Code = int.Parse(code_txt.Text),
                    ItemName = name_txt.Text,
                    UOMeasure = unit_txt.Text,
                    StoreId = int.Parse(comboBox1.SelectedValue.ToString()),
                };
                context.Items.Add(items);
                context.SaveChanges();
                MessageBox.Show("Data inserted successfully.");
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
                int code = int.Parse(code_txt.Text);
                Items itemsCode = context.Items.FirstOrDefault(a => a.Code == code);
                if (itemsCode != null)
                {
                    itemsCode.ItemName = name_txt.Text;
                    itemsCode.UOMeasure = unit_txt.Text;
                    itemsCode.StoreId = int.Parse(comboBox1.SelectedValue.ToString());
                    context.SaveChanges();

                    MessageBox.Show("Data updated successfully.");
                }
                else
                {
                    MessageBox.Show("Item not found.");
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Items_Form_Load(object sender, EventArgs e)
        {
            var item = context.Items.OrderByDescending(x => x.Code).FirstOrDefault();
            if (item != null)
            {
                MessageBox.Show(item.ToString());
                code_txt.Text = item.Code.ToString();
                code_txt.Enabled = true;
            }
            else
            {
                // handle the case where the table is empty
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputName = name_txt.Text;
            MessageBox.Show(inputName.ToString());
            var queryResults = from row in context.Items
                               where row.ItemName == inputName
                               select row;

            listBox1.Items.Clear();

            foreach (var row in queryResults)
            {
                string item = $"{row.Code} - {row.ItemName} - {row.UOMeasure} - {row.StoreId}";
                listBox1.Items.Add(item);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Report_1 report_1=new Report_1();
            report_1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Report_2 report_2=new Report_2();
            report_2.Show();
        }
    }
}
