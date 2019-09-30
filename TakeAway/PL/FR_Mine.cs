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
    public partial class FR_Mine : Form
    {
        public FR_Mine()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FR_MANAGER_USER user = new FR_MANAGER_USER();
            user.Show();
            //pan_MANAGER_USER.BackColor = Color.BlueViolet;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FR_MANAGER_PRUDACT prud = new FR_MANAGER_PRUDACT();
            prud.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FR_MANAGER_TRCKING trck = new FR_MANAGER_TRCKING();
            trck.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            FR_MANAGER_SETTING sett = new FR_MANAGER_SETTING();
            sett.Show();
        }
    }
}
