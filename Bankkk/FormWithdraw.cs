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
    public partial class FormWithdraw : Form
    {
        // dane klienta ktorego obsugujemy
        string log;
        string pass;
        string typeOfAccount;

        public FormWithdraw(string log, string pass, string typeOfAccount)
        {
            this.log = log;
            this.pass = pass;
            this.typeOfAccount = typeOfAccount;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e) // wracam do main window
        {
            this.Hide();
            FormMainWindow f = new FormMainWindow(log, pass, typeOfAccount);
            f.Show();
        }

        public float howMuchWithraw() // pobieram wartosc z bazy danych i dodaje wartosc z txtboxa 
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

            return float.Parse(dt.Rows[0][0].ToString()) + float.Parse(txtHowMuch.Text);
        }

        private void btnWithdraw_Click(object sender, EventArgs e) // updatuje wartosc w saldo dla danego klienta
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wojtek\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            string query;
            if(typeOfAccount == "p")
            {
                query = "update Login set saldo = @saldoParam where username = '" + log + "'";
            }
            else
            {
                query = "update Login2 set saldo = @saldoParam where username = '" + log + "'";
            }
            SqlCommand sqlCmd = new SqlCommand(query, con);

            sqlCmd.Parameters.Add("@saldoParam", SqlDbType.Float);
            sqlCmd.Parameters["@saldoParam"].Value = howMuchWithraw();

            con.Open();
            sqlCmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successful withdraw");

            txtHowMuch.Text = "";
        }
    }
}
