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
    public partial class FR_MANAGER_SETTING : Form
    {
        public FR_MANAGER_SETTING()
        {
            InitializeComponent();
        }

        private void panel25_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            grp_RESTART.Visible = false;
            grp_BACKUP.Visible = true;
            grp_RECOVERY.Visible = false;
            grp_SERVER.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            grp_SERVER.Visible = true;
            grp_RESTART.Visible = false;
            grp_BACKUP.Visible = false;
            grp_RECOVERY.Visible = false;
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            grp_RESTART.Visible = true;
            grp_BACKUP.Visible = false;
            grp_RECOVERY.Visible = false;
            grp_SERVER.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            grp_RESTART.Visible = false;
            grp_BACKUP.Visible = false;
            grp_RECOVERY.Visible = true;
            grp_SERVER.Visible = false;
        }
    }
}
