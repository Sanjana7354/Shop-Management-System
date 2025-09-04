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
    public partial class Edit_customer : Form
    {
        SQLClass Obj = new SQLClass();  
        public Edit_customer()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Obj.Execute_Query("select * from customer_info where contact_no='" + textBox1.Text + "'");
            {
                textBox2.Text = Obj.sqlds.Tables[0].Rows[0].ItemArray[0].ToString().Trim();
                textBox3.Text = Obj.sqlds.Tables[0].Rows[0].ItemArray[1].ToString().Trim();
                textBox4.Text = Obj.sqlds.Tables[0].Rows[0].ItemArray[2].ToString().Trim();
                comboBox1.Text = Obj.sqlds.Tables[0].Rows[0].ItemArray[4].ToString().Trim();
                comboBox2.Text = Obj.sqlds.Tables[0].Rows[0].ItemArray[5].ToString().Trim();    
                textBox6.Text = Obj.sqlds.Tables[0].Rows[0].ItemArray[6].ToString().Trim();
                textBox7.Text = Obj.sqlds.Tables[0].Rows[0].ItemArray[7].ToString().Trim();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            textBox6.ReadOnly = false;
            textBox7.ReadOnly = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Obj.Update("Update customer_info  Set first_name='"+textBox2.Text+"',last_name='"+textBox3.Text+"',email_id='"+textBox4.Text+"',contact_no='"+comboBox1.Text+"',contact_type='"+comboBox2.Text+"',address='"+textBox6.Text +"',city='"+textBox7.Text+"'");
            {
                MessageBox.Show(" Data store successfully");
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_menu f2 = new Main_menu();
            f2.Show();
        }
    }
}
