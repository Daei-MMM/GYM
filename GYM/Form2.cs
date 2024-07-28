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
        private void cut_Click(Object sender, EventArgs e)
        {
            MessageBox.Show("CUT");
        }
        private void copy2_Click(Object sender, EventArgs e)
        {
            MessageBox.Show("CUT");
        }
        private void paste2_Click(Object sender, EventArgs e)
        {
            MessageBox.Show("CUT");
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                ContextMenu cm = new ContextMenu();
                this.ContextMenu = cm;
                cm.MenuItems.Add(new MenuItem("&Cut", new System.EventHandler(this.cut_Click)));
                cm.MenuItems.Add(new MenuItem("&Copy", new System.EventHandler(this.copy2_Click)));
                cm.MenuItems.Add(new MenuItem("&Paste", new System.EventHandler(this.paste2_Click)));



                cm.Show(this, new Point(e.RowIndex, e.ColumnIndex));
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu cm = new ContextMenu();
                this.ContextMenu = cm;
                cm.MenuItems.Add(new MenuItem("&Cut", new System.EventHandler(this.cut_Click)));
                cm.MenuItems.Add(new MenuItem("&Copy", new System.EventHandler(this.copy2_Click)));
                cm.MenuItems.Add(new MenuItem("&Paste", new System.EventHandler(this.paste2_Click)));



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
    }
}
