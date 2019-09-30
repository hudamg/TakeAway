using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeAway.PL
{
    public partial class FR_MANAGER_USER : Form
    {
        public FR_MANAGER_USER()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            FR_MANAGER_SETTING sett = new FR_MANAGER_SETTING();
            sett.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FR_MANAGER_TRCKING trck = new FR_MANAGER_TRCKING();
            trck.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FR_MANAGER_PRUDACT prud = new FR_MANAGER_PRUDACT();
            prud.Show();
        }
    }
}
