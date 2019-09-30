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
    public partial class FR_MANAGER_TRCKING : Form
    {
        public FR_MANAGER_TRCKING()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            FR_MANAGER_SETTING sett = new FR_MANAGER_SETTING();
            sett.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FR_MANAGER_PRUDACT prud = new FR_MANAGER_PRUDACT();
            prud.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FR_MANAGER_USER user = new FR_MANAGER_USER();
            user.Show();
        }
    }
}
