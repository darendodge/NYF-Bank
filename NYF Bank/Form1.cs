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
    public partial class Form1 : Form
    {
        Account darensAccount;
        const int MAX_CUST = 100;
        static Account[] Bank = new Account[MAX_CUST];

        public static string name;
        public static string address;
        public static int accountNumber;
        public static double balance;
        public static int overdraft;


        //public static string variables;




        enum AccountState
        {
            Active,
            Closed,
            Frozen,
            New,
            UnderAudit
        }

        struct Account
        {
            public AccountState State;
            public  string Name;
            public string Address;
            public int AccountNumber;
            public double Balance;
            public int Overdraft;
        }
        public static void newAccountData(string n, string ad, int ac, double b, int o)
        {
            name = n;
            address = ad;
            accountNumber = ac;
            balance = b;
            overdraft = o;

            int counter = 0;
            for (int i = 0; i < MAX_CUST; i++)
            {
                if (Bank[i].AccountNumber < 100000)
                {
                    counter = i;
                    return;
                }
            }
            Bank[counter].Name = n;


        }

        private void TestShow(Account a)
        {
            MessageBox.Show(a.Name);
        }

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            darensAccount.Name = "Daren Dodge";
            darensAccount.Balance = 100.10;
            darensAccount.State = AccountState.Active;


        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            TestShow(darensAccount);
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
