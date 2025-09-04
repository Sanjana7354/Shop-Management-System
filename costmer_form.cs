using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Management
{
    public partial class costmer_form : Form
    {
        SQLClass Obj =new SQLClass();
        public costmer_form()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_menu f2 = new Main_menu();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Obj.insert_Query("insert into customer_info (first_name,last_name,email_id,contact_no,contact_type,gender,address,city) values ('" + textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+comboBox1.Text+"','"+comboBox2.Text+"','"+textBox5.Text+"','"+textBox6.Text+"') ");
           MessageBox.Show("Data Insert Successfully");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_menu f2 = new Main_menu();
            f2.Show();
        }
    }
}
