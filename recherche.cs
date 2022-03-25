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

namespace cimentbizert
{
    
    public partial class recherche : Form
    {
        public recherche()
        {
            InitializeComponent();
        }

        SqlConnection cnx = new SqlConnection
        {
            ConnectionString = @"Data Source=yosri;Initial Catalog=ciment;Integrated Security=True"
        };
        bool b = false;

        SqlCommand cmd = new SqlCommand();

        public void Deconncter()
        {
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
        }
        DataTable table = new DataTable();
        SqlDataReader Reader;

       

        public void Reinitialisation()
        {
            getmat.Clear();
        }

        private void getbtn_Click(object sender, EventArgs e)
        {


            Deconncter();
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from employee WHERE matricule = '" + getmat.Text + "';", cnx);
            Reader = cmd.ExecuteReader();

            if (Reader.Read())
            {

                name.Text = Reader[3].ToString();
                pname.Text = Reader[4].ToString();
                mat.Text = Reader[1].ToString();
                cin.Text = Reader[2].ToString();
                cnam.Text = Reader[11].ToString();
                date.Text = Reader[13].ToString();
                nc.Text = Reader[8].ToString();
                pnc.Text = Reader[9].ToString();
                grade.Text = Reader[7].ToString();
                nenfant.Text = Reader[12].ToString();
                etatc.Text = Reader[6].ToString();
                adr.Text = Reader[5].ToString();
                numtel.Text = Reader[10].ToString();
                solde.Text = Reader[14].ToString();
            }


            else
            {
                MessageBox.Show("Cette réference n'existe pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cnx.Close();
        }

        private void pname_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
