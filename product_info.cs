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

namespace Shop_Management
{
    public partial class product_info : Form
    {
        SQLClass Obj =new SQLClass();
        
        public static string date;

        public product_info()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Obj.insert_Query("insert into product_info (product_id,product_name,product_company,price_cost,manufacturing_date,expire_date,quantity,price_sell,entry_date,Total_Cost) values ('" + textBox1.Text+ "','"+textBox2.Text+ "','"+textBox3.Text+ "','"+textBox4.Text+ "','"+ dateTimePicker3.Value.Date + "','"+dateTimePicker2.Value.Date + "','"+textBox7.Text+ "','"+textBox8.Text+ "','"+ dateTimePicker1.Value.Date + "','"+textBox5.Text+ "') ");
            MessageBox.Show("Data Insert Successfully");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_menu f2 = new Main_menu(); 
            f2.Show();       
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            float a =float.Parse(textBox4.Text);
            float b =float.Parse(textBox7.Text);
            float c=a*b;
            textBox5.Text=c.ToString();
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void product_info_Load(object sender, EventArgs e)
        {

        }
    }
}
