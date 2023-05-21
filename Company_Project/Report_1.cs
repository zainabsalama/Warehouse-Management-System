using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Company_Project
{
    public partial class Report_1 : Form
    {
        Context context = new Context();
        public Report_1()
        {
            InitializeComponent();
            var ExportName = from t in context.Exports
                            orderby t.ExportCode
                            select t;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DataSource = ExportName.ToList();
            comboBox1.DisplayMember = "ExportCode";
            comboBox1.ValueMember = "ExportCode";
           
        }

        private void Report_1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(comboBox1.SelectedValue.ToString());
            Export_Permission export = context.Exports.FirstOrDefault(i => i.ExportCode == id);
            if (export != null)
            {
                DateTime currentDate = DateTime.Now;
                TimeSpan timeDifference = currentDate - export.ExportDate;
                int daysDifference = timeDifference.Days;
                textBox2.Text = daysDifference.ToString();


                context.SaveChanges();
            }
        }
    }
}
