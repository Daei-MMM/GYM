using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MasterClass mc = new MasterClass();
            if (mc.Login(comboBox1.Text,maskedTextBox1.Text))
            { 
                Form2 frm=new Form2();
                frm.Show();
            }
            else
            {
                msg m = new msg();
                MessageBox.Show(m.login_is_invalid);
            }
        }
    }
}
