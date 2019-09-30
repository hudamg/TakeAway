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
    public partial class FR__EmployeeDebt : Form
    {
        public FR__EmployeeDebt()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FR_Salaries salaries = new FR_Salaries();
            salaries.ShowDialog();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FR__EmployeeDebt employeeDebt = new FR__EmployeeDebt();
            employeeDebt.ShowDialog();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FR_Marketers marketers = new FR_Marketers();
            marketers.ShowDialog();
            this.Hide();
        }
    }
}
