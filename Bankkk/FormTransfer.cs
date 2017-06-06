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

namespace Bankkk
{
    public partial class FormTransfer : Form
    {
        string log;
        string pass;
        string typeOfAccount;
        string typeOfReceiver;

        public FormTransfer(string log, string pass, string typeOfAccount)
        {
            this.log = log;
            this.pass = pass;
            this.typeOfAccount = typeOfAccount;
            InitializeComponent();
            txtPass.Text = "";
            txtPass.PasswordChar = '*';
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMainWindow f = new FormMainWindow(log, pass, typeOfAccount);
            f.Show();
        }

        public float howMuchWithraw() // pobieram wartosc z bazy danych i dodaje wartosc z txtboxa 
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wojtek\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda;
            if (typeOfReceiver == "p")
            {
                sda = new SqlDataAdapter("Select Saldo From Login where Username = '" + txtWhom.Text +
                "'", con);
            }
            else
            {
                sda = new SqlDataAdapter("Select Saldo From Login2 where Username = '" + txtWhom.Text +
                "'", con);
            }
            DataTable dt = new DataTable();
            sda.Fill(dt);

            return float.Parse(dt.Rows[0][0].ToString()) + float.Parse(txtHowMuch.Text);
        }

        public float howMuchPay() // pobieram wartosc z bazy danych i odejmuje wartosc z txtboxa 
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wojtek\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda;
            if (typeOfAccount == "p")
            {
                sda = new SqlDataAdapter("Select Saldo From Login where Username = '" + log +
                "' and Password = '" + pass + "'", con);
            }
            else
            {
                sda = new SqlDataAdapter("Select Saldo From Login2 where Username = '" + log +
                "' and Password = '" + pass + "'", con);
            }
            DataTable dt = new DataTable();
            sda.Fill(dt);

            return float.Parse(dt.Rows[0][0].ToString()) - float.Parse(txtHowMuch.Text);
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (radFirm.Checked) { typeOfReceiver = "f"; }
            if (radPrivate.Checked) { typeOfReceiver = "p"; }
            if (pass == txtPass.Text.ToString()) // weryfikacja
            {
                // wyplacam z konta osoby ktora przelewa
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wojtek\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
                string query;
                if (typeOfAccount == "p")
                {
                    query = "update Login set saldo = @saldoParam where username = '" + log + "'";
                }
                else
                {
                    query = "update Login2 set saldo = @saldoParam where username = '" + log + "'";
                }
                SqlCommand sqlCmd = new SqlCommand(query, con);

                sqlCmd.Parameters.Add("@saldoParam", SqlDbType.Float);
                sqlCmd.Parameters["@saldoParam"].Value = howMuchPay();

                con.Open();
                sqlCmd.ExecuteNonQuery();
                con.Close();

                // teraz bede wplacal to co wyplacilem do celu (konta)

                SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wojtek\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
                string query2;
                if (typeOfReceiver == "p")
                {
                    query2 = "update Login set saldo = @saldoParam where username = '" + txtWhom.Text + "'";
                }
                else
                {
                    query2 = "update Login2 set saldo = @saldoParam where username = '" + txtWhom.Text + "'";
                }
                SqlCommand sqlCmd2 = new SqlCommand(query2, con2);

                sqlCmd2.Parameters.Add("@saldoParam", SqlDbType.Float);
                sqlCmd2.Parameters["@saldoParam"].Value = howMuchWithraw();

                con2.Open();
                sqlCmd2.ExecuteNonQuery();
                con2.Close();

                // messsage
                MessageBox.Show("Successful transfer.");

                // czyszcze textboxy
                txtHowMuch.Text = "";
                txtPass.Text = "";
                txtWhom.Text = "";
            }
            else
            {
                // message
                MessageBox.Show("Incorrect password!");
            }
            
        }
    }
}
