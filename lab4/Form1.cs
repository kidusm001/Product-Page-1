using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab4;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
           
            Item i = new Item
            {
                itemName = txt_objectName.Text,
                number = int.Parse(txt_number.Text),
                inventoryNumber = int.Parse(txt_inventoryNumber.Text),
                price = Convert.ToDouble(txt_price.Text),
                count = int.Parse(txt_count.Text),
                date = txt_date.Text
            };
       
                i.save();
                MessageBox.Show("Saved");
            
            

        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
