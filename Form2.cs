using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Shop_Management
{
    public partial class Form2 : Form
    {
        SQLClass Obj = new SQLClass();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Obj.Execute_Query("select count(user_name) as No_of_User from log_in where user_name = '" + textBox1.Text + "' and password = '" + textBox2.Text + "' ");
            if (Obj.sqlds.Tables[0].Rows[0].ItemArray[0].ToString().Equals("1"))
            {
                this.Hide();
                Main_menu f2 = new Main_menu();
                f2.Show();
            }

            else
            {
                MessageBox.Show("Invlid Username Password");
            }

        } 

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Sign_up f2 = new Sign_up();
            f2.Show();
        }

        

        /*private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drv in dataGridView1.Rows)
            {
                Obj.insert_Query("insert into my_id (id,salary,address,name) values ('" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text +"' ");
                MessageBox.Show("Data Insert Successfully");
            }
        }*/

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}


