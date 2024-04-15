using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITEC103_LOG_IN
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            this.Close();
            new welcome().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Show();
        }
    }
}
