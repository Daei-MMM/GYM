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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void barname(Object sender, EventArgs e)
        {
            tabControl2.SelectTab(tabbarname);
            codemeliM.Focus();
            codemeliM.Text =varzeshkaranG.CurrentCell.Value.ToString();
            
        }
        private void hadaf(Object sender, EventArgs e)
        {
            tabControl2.SelectTab(tabhadaf);
            codemelihadafMT.Text= varzeshkaranG.CurrentCell.Value.ToString();
            codemelihadafMT.Focus();
        }
        private void dore(Object sender, EventArgs e)
        {
            tabControl2.SelectTab(tabdore);
            codemeilidoreM.Text = varzeshkaranG.CurrentCell.Value.ToString();
            codemeilidoreM.Focus();

        }
        private void shahrie(Object sender, EventArgs e)
        {
            tabControl2.SelectTab(tabshahrie);
            MTcodemelish.Text = varzeshkaranG.CurrentCell.Value.ToString();
            MTcodemelish.Focus();

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu cm = new ContextMenu();
                this.ContextMenu = cm;
                cm.MenuItems.Add(new MenuItem("&ثبت برنامه", new System.EventHandler(this.barname)));
                cm.MenuItems.Add(new MenuItem("&ثبت هدف", new System.EventHandler(this.hadaf)));
                cm.MenuItems.Add(new MenuItem("&ثبت دوره", new System.EventHandler(this.dore)));
                cm.MenuItems.Add(new MenuItem("&ثبت شهریه", new System.EventHandler(this.shahrie)));



                cm.Show(this, new Point(e.X, e.Y));
            }

        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBox28_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox20_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void MTcodemelish_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                msg ms = new msg();
                if (MTcodemelish.Text == "")
                {
                    
                    MessageBox.Show(ms.id);
                    MTcodemelish.Focus();
                    return;
                }
                MasterClass mc = new MasterClass();
                if (mc.Check_id_invalid(MTcodemelish.Text))
                {
                    MessageBox.Show(ms.id_invalid);
                    return;
                }
                Tnameshahrie.Text = mc.name(MTcodemelish.Text);
                Tfamilyshahrie.Text = mc.family(MTcodemelish.Text);
                Tbedehishah.Text = mc.shahrie(MTcodemelish.Text);
            }
        }

        private void addvarzeshB_Click(object sender, EventArgs e)
        {
            msg ms = new msg();
            bool check = true;
            if (Tname.Text == "")
            {
                MessageBox.Show(ms.name);
                Tname.Focus();
                Tname.BackColor = Color.Red;
                check = false;
            }

            if (Tfamily.Text == "")
            {
                MessageBox.Show(ms.family);
                Tfamily.Focus();
                Tfamily.BackColor = Color.Red;
                check = false;
            }
            if (Tid.Text == "")
            {
                MessageBox.Show(ms.id);
                Tid.Focus();
                Tid.BackColor = Color.Red;
                check = false;
            }
            
            MasterClass mc = new MasterClass();
            if (mc.Check_id_invalid(Tid.Text))
            {
                MessageBox.Show(ms.id_invalid);
                Tid.Focus();
                Tid.BackColor = Color.Red;
                check = false;
            }

            if (!check)
                return;
            
        }

        private void Tid_Enter(object sender, EventArgs e)
        {
            Tid.BackColor = Color.White;
           
        }

        private void Tname_TextChanged(object sender, EventArgs e)
        {
            Tname.BackColor = Color.White;
        }

        private void Tfamily_TextChanged(object sender, EventArgs e)
        {
            Tfamily.BackColor = Color.White;
        }
    }
}
