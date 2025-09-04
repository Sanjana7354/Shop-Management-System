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
    public partial class Main_menu : Form
    {
        SQLClass Obj = new SQLClass();
        
        public Main_menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f2 = new Form1();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            product_info f2 = new product_info();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Edit_product f2 = new Edit_product();
            f2.Show();
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            costmer_form f2 = new costmer_form();
            f2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Edit_customer f2 = new Edit_customer();
            f2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Billing_system f2 = new Billing_system();
            f2.Show();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_menu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}

