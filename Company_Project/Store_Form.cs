using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Company_Project
{
    
    public partial class Store_Form : Form
    {
        Context context = new Context();
        public Store_Form()
        {
            InitializeComponent();
            var item = context.Stores.OrderByDescending(x => x.Id).FirstOrDefault();
            MessageBox.Show(item.ToString());
            if (item != null)
            {
                id_txt.Text = item.Id.ToString();
                id_txt.Enabled = true;
            }
            else
            {
                // handle the case where the table is empty
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Store store = new Store()
                {
                    Id=int.Parse(id_txt.Text),
                    CompName = name_txt.Text,
                    CompManager = manager_txt.Text,
                    Location = loc_txt.Text,
                };
                context.Stores.Add(store);
                context.SaveChanges();

                MessageBox.Show("Data saved successfully.");

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the data: " + ex.Message);
            }
        }
        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(id_txt.Text);
                Store store = context.Stores.FirstOrDefault(a => a.Id == id);

                if (store != null)
                {
                    store.CompName = name_txt.Text;
                    store.Location = loc_txt.Text;
                    store.CompManager = manager_txt.Text;

                    context.SaveChanges();

                    MessageBox.Show("Data updated successfully.");
                }
                else
                {
                    MessageBox.Show("Store not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the data: " + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Get the ID from the user
            string inputName = name_txt.Text;
            var queryResults = from row in context.Stores
                               where row.CompName == inputName
                               select row;

            listBox1.Items.Clear();

            foreach (var row in queryResults)
            {
                string item = $"{row.Id} - {row.CompName} - {row.CompManager} - {row.Location}";
                listBox1.Items.Add(item);
             
            }
        }
    }
}
