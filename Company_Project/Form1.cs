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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void store_btn_Click(object sender, EventArgs e)
        {
            Store_Form store=new Store_Form();
            store.Show();
        }

        private void item_btn_Click_1(object sender, EventArgs e)
        {
            Items_Form items = new Items_Form();
            items.Show();
            Invalidate();
        }

        private void suppliers_btn_Click(object sender, EventArgs e)
        {
            Suppliers_Form suppliers = new Suppliers_Form();
            suppliers.Show();
        }

        private void customers_btn_Click(object sender, EventArgs e)
        {
            Customers_Form customers = new Customers_Form();
            customers.Show();
        }

        private void import_btn_Click(object sender, EventArgs e)
        {
            Import_Form import= new Import_Form();
            import.Show();
        }

        private void export_btn_Click(object sender, EventArgs e)
        {
            Export_Form export=new Export_Form();
            export.Show();
        }

        private void transfer_btn_Click(object sender, EventArgs e)
        {
            Transfer_Form transfer=new Transfer_Form();
            transfer.Show();
        }
    }
}
