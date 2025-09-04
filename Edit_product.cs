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
    public partial class Edit_product : Form
    {
        SQLClass Obj = new SQLClass();
        public Edit_product()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Obj.Execute_Query("select * from product_info where product_id='" + textBox1.Text + "'");
            {
                textBox2.Text = Obj.sqlds.Tables[0].Rows[0].ItemArray[1].ToString().Trim();
                textBox3.Text = Obj.sqlds.Tables[0].Rows[0].ItemArray[2].ToString().Trim();
                textBox4.Text = Obj.sqlds.Tables[0].Rows[0].ItemArray[3].ToString().Trim();
                textBox5.Text = Obj.sqlds.Tables[0].Rows[0].ItemArray[4].ToString().Trim();
                textBox6.Text = Obj.sqlds.Tables[0].Rows[0].ItemArray[5].ToString().Trim();
                textBox7.Text = Obj.sqlds.Tables[0].Rows[0].ItemArray[6].ToString().Trim();
                textBox8.Text = Obj.sqlds.Tables[0].Rows[0].ItemArray[7].ToString().Trim();
                textBox9.Text = Obj.sqlds.Tables[0].Rows[0].ItemArray[8].ToString().Trim();
                textBox10.Text = Obj.sqlds.Tables[0].Rows[0].ItemArray[9].ToString().Trim();
            }
        }

        private void Edit_product_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_menu f2 = new Main_menu();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox5.ReadOnly = false;
            textBox6.ReadOnly = false;
            textBox7.ReadOnly = false;
            textBox8.ReadOnly = false;
            textBox9.ReadOnly = false;
            textBox10.ReadOnly = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Obj.Update("Update product_info  Set product_name='" + textBox2.Text + "',product_company='" + textBox3.Text + "',price_cost='" + textBox4.Text + "',manufacturing_date='" + textBox5.Text + "',expire_date='" + textBox6.Text + "',quantity='" + textBox7.Text + "',price_sell='" + textBox8.Text + "',entry_date='" + textBox9.Text + "',Total_Cost='" + textBox10.Text + "' where product_id = '" + textBox1.Text + "' ");
            {
                MessageBox.Show(" Data store");
                this.Close();
            }

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            float a = float.Parse(textBox4.Text);
            float b = float.Parse(textBox7.Text);
            float c = a * b;

            textBox10.Text = c.ToString();  
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
