using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Bankkk
{
    public partial class FormMainWindow : Form
    {
        // stringi przechowuja dane obsugiwanego klienta
        string log;
        string pass;
        string typeOfAccount;

        public FormMainWindow(string log, string pass, string typeOfAccount) // konstruktor pobiera dane klienta ktorego obsugujemy 
        {
            this.log = log;
            this.pass = pass;
            this.typeOfAccount = typeOfAccount;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) // zamkniecie
        {
            this.Close();
        }

        private void btnLogOff_Click(object sender, EventArgs e) // wylogowanie sie i przeniesienie do okna logowania
        {
            this.Hide();
            FormLoign f = new FormLoign();
            f.Show();
            MessageBox.Show("You are succesfully logged off.");
        }

        private void btnGetYourInfo_Click(object sender, EventArgs e) // wyswietlamy dane klienta
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wojtek\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            if(typeOfAccount == "p")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select Name, Surname, Dateofbirth, Age From Login where Username = '"
                + log + "' and Password = '" + pass + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                MessageBox.Show("Name:" + dt.Rows[0][0].ToString() + "\nSurname: " + dt.Rows[0][1].ToString() + "\nDate of birth: "
                    + dt.Rows[0][2].ToString() + "\nAge: " + dt.Rows[0][3].ToString());
            }
            else
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select Name, Street, Postalcode, Typeofcompany, Nip, Regon, Krs From Login2 where Username = '"
                + log + "' and Password = '" + pass + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                MessageBox.Show("Firm Name: " + dt.Rows[0][0].ToString() + "\nAddress: " + dt.Rows[0][1].ToString() + "\nPostal Code: "
                    + dt.Rows[0][2].ToString() + "\nType of company: " + dt.Rows[0][3].ToString() + "\nNIP: " 
                    + dt.Rows[0][4].ToString() + "\nREGON: " + dt.Rows[0][5].ToString() + "\nKRS: " 
                    + dt.Rows[0][6].ToString());
            }
        }

        private void btnSaldo_Click(object sender, EventArgs e) // wyswietla stan konta
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wojtek\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            if (typeOfAccount == "p")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select Saldo From Login where Username = '" + log +
                "' and Password = '" + pass + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                MessageBox.Show("Your saldo is: " + float.Parse(dt.Rows[0][0].ToString()) + " pesos"); // moja waluta 'pesos'
            }
            else
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select Saldo From Login2 where Username = '" + log +
                "' and Password = '" + pass + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                MessageBox.Show("Your saldo is: " + float.Parse(dt.Rows[0][0].ToString()) + " pesos"); // moja waluta 'pesos'
            }
        }
        private void btnWithdraw_Click(object sender, EventArgs e) // jak chcemy cos wplacic to dzieje sie to w innym oknie
        {
            this.Hide();
            FormWithdraw f = new FormWithdraw(log, pass, typeOfAccount);
            f.Show();
        }

        private void btnPay_Click(object sender, EventArgs e) // jak chcemy cos wyplacic to dzieje sie to w innym oknie
        {
            this.Hide();
            FormPay f = new FormPay(log, pass, typeOfAccount);
            f.Show();
        }

        private void btnTransfer_Click(object sender, EventArgs e) // tradycyjnie transfer w innym oknie
        {
            this.Hide();
            FormTransfer f = new FormTransfer(log, pass, typeOfAccount);
            f.Show();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDeleteAccount f = new FormDeleteAccount(pass, log, typeOfAccount);
            f.Show();
        }
    }
}
