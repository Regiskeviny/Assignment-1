using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Panel2.controls.clear();
            Form1 def = new Form1();
            Panel2.Add(def);
            def.Show();

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            Panel2.controls.clear();
            Form1 def = new Form1();
            Panel2.Add(def);
            def.Show();

        }
    }
}
