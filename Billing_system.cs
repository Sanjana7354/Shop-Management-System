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
    public partial class Billing_system : Form
    {
        SQLClass Obj = new SQLClass();
        public Billing_system()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this .Close();  
            Main_menu f2 = new Main_menu();
            f2.Show();  
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            Obj.Execute_Query("select * from customer_info where contact_no='" + textBox1.Text + "'");
            {
                textBox2.Text = Obj.sqlds.Tables[0].Rows[0].ItemArray[0].ToString().Trim();
                textBox3.Text = Obj.sqlds.Tables[0].Rows[0].ItemArray[6].ToString().Trim();
                textBox8.Text = Obj.sqlds.Tables[0].Rows[0].ItemArray[2].ToString().Trim();

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Obj.Execute_Query("select * from product_info where product_id='" + textBox4.Text + "'");
            {
                textBox5.Text = Obj.sqlds.Tables[0].Rows[0].ItemArray[1].ToString().Trim();
                textBox6.Text = Obj.sqlds.Tables[0].Rows[0].ItemArray[7].ToString().Trim();
                textBox7.Text = Obj.sqlds.Tables[0].Rows[0].ItemArray[6].ToString().Trim();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Billing_system_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
           
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
