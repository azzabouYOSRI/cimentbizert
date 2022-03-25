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
    public partial class suprimer : Form
    {
        SqlConnection cnx = new SqlConnection
        {
            ConnectionString = @"Data Source=yosri;Initial Catalog=ciment;Integrated Security=True"
        };
        bool b = false;

        SqlCommand cmd = new SqlCommand();
        SqlDataReader Reader;

        public void Deconncter()
        {
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
        }
        DataTable table = new DataTable();
        public int Trouver()
        {
            int x = 0;
            Deconncter();
            cnx.Open();
            string my = "select count(*) from employee WHERE matricule = '" + SU1.Text + "'";
            cmd = new SqlCommand(my, cnx);
            x = Convert.ToInt32(cmd.ExecuteScalar());
            cnx.Close();
            return x;
        }

        
        public void Reinitialisation()
        {

            SU1.Clear();
        }


            public suprimer()
        {
            InitializeComponent();
        }
       
        private void supp_Click(object sender, EventArgs e)
        {

            if (Trouver() == 0)
            {
                MessageBox.Show("Ce numéro de facture n'existe pas!", "Attention",
       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Deconncter();
                cnx.Open();
                SqlCommand cmd = new SqlCommand("delete from employee where matricule='" + SU1.Text + "'", cnx);

                int i = cmd.ExecuteNonQuery();

                MessageBox.Show("supression effectuée avec succes!", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reinitialisation();
                cnx.Close();
                b = true;

            }
            
        }

        private void SU1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
