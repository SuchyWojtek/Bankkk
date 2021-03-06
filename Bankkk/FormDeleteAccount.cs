﻿using System;
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
    public partial class FormDeleteAccount : Form
    {
        string pass,log,typeOfAccount;

        public FormDeleteAccount(string pass, string log, string typeOfAccount)
        {
            InitializeComponent();
            this.pass = pass;
            this.log = log;
            this.typeOfAccount = typeOfAccount;
            txtDelete.PasswordChar = '*';
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMainWindow f = new FormMainWindow(log,pass,typeOfAccount);
            f.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(pass == txtDelete.Text.ToString())
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wojtek\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
                string query;
                if(typeOfAccount == "p")
                {
                    query = "delete from Login where Username = '" + log + "' and Password = '" + pass + "'";
                }
                else
                {
                    query = "delete from Login2 where Username = '" + log + "' and Password = '" + pass + "'";
                }
                SqlCommand cmd = new SqlCommand(query, con);

                // wykonuje polecenie sql
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                // wracamy do okna logowania
                FormLoign f = new FormLoign();
                this.Hide();
                MessageBox.Show("Success delete.");
                f.Show();
            }
            else
            {
                MessageBox.Show("Bad password!");
                txtDelete.Clear();
            }
        }
    }
}
