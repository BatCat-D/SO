using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Red;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.FromArgb(32, 166, 60);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox2.PasswordChar='\0';
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            pictureBox4.Visible = false;
            pictureBox3.Visible = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            // واجهة تعرض تعليمات + يمكن من خلالها تغيير المستخدم وكلمة السر **سيتم عملها فيما بعد** يعتمد
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Blue;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.FromArgb(32, 166, 60);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="كنترول" && textBox2.Text=="control" )
            {
                Form2  frm = new Form2();
                frm.Show();
                this.Hide();
            }
            else
            {
                label6.Show();
            }
        }
         
    }
}
