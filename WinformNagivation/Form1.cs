using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformNagivation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            nav(home, content);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Products product = new Products();
            nav(product, content);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Buy buy = new Buy();
            nav(buy, content);
        }

        public void nav(Form form,Panel panel)
        {
            form.TopLevel = false;
            form.Size = panel.Size; // for responsive size
            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();
        }
    }
}
