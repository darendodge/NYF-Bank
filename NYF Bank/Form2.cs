using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NYF_Bank
{
    public partial class Form2 : Form

    {


        public Form2()
        {
            InitializeComponent();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string address = txtAddress.Text;
            int accountNumber = Convert.ToInt32(txtAccountNum.Text);
            double balance = Convert.ToDouble(txtBalance.Text);
            int overdraft = Convert.ToInt32(txtOverdraft);
 
            Form1.newAccountData(name,address,accountNumber,balance,overdraft); //passing the variables back to the method
            Close();


        }
    }
}
