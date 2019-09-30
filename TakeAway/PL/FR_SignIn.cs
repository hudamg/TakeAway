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
    public partial class FR_SignIn : Form
    {
        public FR_SignIn()
        {
            InitializeComponent(); 
        }
        
        private void txt_USER_NAME_TextChanged(object sender, EventArgs e)
        {
            pan_USER_NAME.BackColor = Color.Crimson;   
        }

        private void txt_USER_NAME_Leave(object sender, EventArgs e)
        {
            pan_USER_NAME.BackColor = Color.WhiteSmoke;
        }

        private void txt_PASSWORD_TextChanged(object sender, EventArgs e)
        {
            pan_PASSWORD.BackColor = Color.Crimson; 
        }

        private void txt_PASSWORD_Leave(object sender, EventArgs e)
        {
            pan_PASSWORD.BackColor = Color.WhiteSmoke;
        }

        private void btn_LOGIN_Click(object sender, EventArgs e)
        {
            FR_Mine mine = new FR_Mine();
            mine.Show();
            this.Hide();
        }

        private void btn_CREATE_USER_Click(object sender, EventArgs e)
        {
            FR_CreateAccount creatUSER = new FR_CreateAccount();
            creatUSER.Show();
            this.Hide();
        }


    }
}
