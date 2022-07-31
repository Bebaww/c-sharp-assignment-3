using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace assignment_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            property p = new property { item_name = txt_itemname.Text, inventory_number = txt_inventory.Text, number = Convert.ToInt32(txt_number.Text), price = Convert.ToInt32(txt_price.Text), count = Convert.ToInt32(txt_count.Text) };
           
            
           /* Regex reg = new Regex(@"^[0-9]{3}$");
          if ( ! reg.IsMatch(txt_count.Text))
            {
                errorProvider1.SetError(txt_count, "invald count");
               
            }
          */




                MessageBox.Show($"product    {p.item_name}  added sucessfuy");
            p.save();
            /*
            dataGridView.DataSource = null;
            dataGridView.DataSource = property.getallproducts();
            errorProvider1.Clear();
            */
        }

      

        private void btn_cancel_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            property a = new property();
            txt_itemname.Text = "";
            txt_count.Text = null;
            txt_inventory.Text = "";
            txt_number.Text = null;
            txt_price.Text = null;

        }

        private void txt_number_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }
    }
}