using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Shop_Management
{
    public partial class Form1 : Form
    {
        SQLClass Obj = new SQLClass();
        public static string user_name = "", password = "",name="";
        public Form1()
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

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_up f2 = new Sign_up();
            f2.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
