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

        public FormTransfer(string log, string pass)
        {
            this.log = log;
            this.pass = pass;
            InitializeComponent();
            txtPass.Text = "";
            txtPass.PasswordChar = '*';
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMainWindow f = new FormMainWindow(log, pass);
            f.Show();
        }

        public float howMuchWithraw() // pobieram wartosc z bazy danych i dodaje wartosc z txtboxa 
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wojtek\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Saldo From Login where Username = '" + txtWhom.Text +
                "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            return float.Parse(dt.Rows[0][0].ToString()) + float.Parse(txtHowMuch.Text);
        }

        public float howMuchPay() // pobieram wartosc z bazy danych i odejmuje wartosc z txtboxa 
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wojtek\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Saldo From Login where Username = '" + log +
                "' and Password = '" + pass + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            return float.Parse(dt.Rows[0][0].ToString()) - float.Parse(txtHowMuch.Text);
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (pass == txtPass.Text.ToString()) // weryfikacja
            {
                // wyplacam z konta osoby ktora przelewa
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wojtek\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
                string query = "update Login set saldo = @saldoParam where username = '" + log + "'";
                SqlCommand sqlCmd = new SqlCommand(query, con);

                sqlCmd.Parameters.Add("@saldoParam", SqlDbType.Float);
                sqlCmd.Parameters["@saldoParam"].Value = howMuchPay();

                con.Open();
                sqlCmd.ExecuteNonQuery();
                con.Close();

                // teraz bede wplacal to co wyplacilem do celu (konta)

                SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wojtek\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
                string query2 = "update Login set saldo = @saldoParam where username = '" + txtWhom.Text + "'";
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
