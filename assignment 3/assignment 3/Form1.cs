using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            property p = new property {  item_name=txt_itemname.Text,  inventory_number=txt_inventory.Text     , number = Convert.ToInt32 (txt_number.Text) ,  price = Convert.ToInt32(txt_price.Text),count=Convert.ToInt32(txt_count.Text) };
           
            MessageBox.Show($"product    {p.item_name}  added sucessfuy");
            p.save();
           
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
