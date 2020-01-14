using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void btnStartPause_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1(); //another form will open
            fm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
