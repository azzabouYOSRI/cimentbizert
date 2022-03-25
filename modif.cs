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
    public partial class modif : Form
    {
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
        public int Trouver()
        {
            int x = 0;
            Deconncter();
            cnx.Open();
            string my = "select count(*) from employee WHERE matricule = '" + getmat.Text + "'";
            cmd = new SqlCommand(my, cnx);
            x = Convert.ToInt32(cmd.ExecuteScalar());
            cnx.Close();
            return x;
        }


        public modif()
        {
            InitializeComponent();
        }
        SqlDataReader Reader;
        public void Remplir()
        {
            Deconncter();
            cnx.Open();
            cmd = new SqlCommand("select * from employee WHERE matricule = '" + getmat.Text + "'", cnx);
            Reader = cmd.ExecuteReader();
            table.Load(Reader);
            dataGridView1.DataSource = table;
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }

        }
        public void Reinitialisation()
        {
            name.Clear();
            pname.Clear();
            matr.Clear();
            cin.Clear();
            cnam.Clear();
            year.Clear();
            month.Clear();
            day.Clear();
            nc.Clear();
            pnc.Clear();
            grade.Clear();
            nenfant.Clear();
            etatc.Clear();
            adr.Clear();
            numtel.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void pname_TextChanged(object sender, EventArgs e)
        {

        }

        private void getbtn_Click(object sender, EventArgs e)
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
                Remplir();
                Reinitialisation();
                cnx.Close();
                b = true;

            }

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(matr.Text))
            {
                if (b == true)
                {
                    Deconncter();
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("update employee set matricule='" + matr.Text + "' where matricule = '" + getmat.Text + "'", cnx);

                    int i = cmd.ExecuteNonQuery();

                    MessageBox.Show("Modification effectuée avec succes!", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    table.Clear();
                    Remplir();
                    Reinitialisation();
                    cnx.Close();
                }
            }

            if (!string.IsNullOrEmpty(name.Text))
            {
                if (b == true)
                {
                    Deconncter();
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("update employee set nom='" + name.Text + "' where matricule = '" + getmat.Text + "'", cnx);

                    int i = cmd.ExecuteNonQuery();

                    MessageBox.Show("Modification effectuée avec succes!", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    table.Clear();
                    Remplir();
                    Reinitialisation();
                    cnx.Close();
                }
            }

            if (!string.IsNullOrEmpty(pname.Text))
            {
                if (b == true)
                {
                    Deconncter();
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("update employee set prenom='" + pname.Text + "' where matricule = '" + getmat.Text + "'", cnx);

                    int i = cmd.ExecuteNonQuery();

                    MessageBox.Show("Modification effectuée avec succes!", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    table.Clear();
                    Remplir();
                    Reinitialisation();
                    cnx.Close();
                }
            }

            if (!string.IsNullOrEmpty(cin.Text))
            {
                if (b == true)
                {
                    Deconncter();
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("update employee set cname='" + cnam.Text + "' where matricule = '" + getmat.Text + "'", cnx);

                    int i = cmd.ExecuteNonQuery();

                    MessageBox.Show("Modification effectuée avec succes!", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    table.Clear();
                    Remplir();
                    Reinitialisation();
                    cnx.Close();
                }
            }

            if (!string.IsNullOrEmpty(year.Text) && !string.IsNullOrEmpty(month.Text) && !string.IsNullOrEmpty(day.Text))
            {
                if (b == true)
                {
                    Deconncter();
                    cnx.Open();
                    string date = year.Text + "-" + month.Text + "-" + day.Text;
                    SqlCommand cmd = new SqlCommand("update employee set datenais ='" + date + "' where matricule = '" + getmat.Text + "'", cnx);

                    int i = cmd.ExecuteNonQuery();

                    MessageBox.Show("Modification effectuée avec succes!", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    table.Clear();
                    Remplir();
                    Reinitialisation();
                    cnx.Close();
                }
            }

            if (!string.IsNullOrEmpty(nc.Text))
            {
                if (b == true)
                {
                    Deconncter();
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("update employee set nomcon ='" + nc.Text + "' where matricule = '" + getmat.Text + "'", cnx);

                    int i = cmd.ExecuteNonQuery();

                    MessageBox.Show("Modification effectuée avec succes!", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    table.Clear();
                    Remplir();
                    Reinitialisation();
                    cnx.Close();
                }
            }

            if (!string.IsNullOrEmpty(pnc.Text))
            {
                if (b == true)
                {
                    Deconncter();
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("update employee set prenomcon ='" + pnc.Text + "' where matricule = '" + getmat.Text + "'", cnx);

                    int i = cmd.ExecuteNonQuery();

                    MessageBox.Show("Modification effectuée avec succes!", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    table.Clear();
                    Remplir();
                    Reinitialisation();
                    cnx.Close();
                }
            }

            if (!string.IsNullOrEmpty(grade.Text))
            {
                if (b == true)
                {
                    float solde;
                    string grad = grade.Text;
                    switch (grad)
                    {
                        case "1":
                            solde = 1800;
                            break;
                        case "2":
                            solde = 1800;
                            break;
                        case "3":
                            solde = 1400;
                            break;
                        case "4":
                            solde = 1000;
                            break;
                        default:
                            solde = 600;
                            break;
                    }
                    Deconncter();
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("update employee set grade='" + grade.Text + "' where matricule = '" + getmat.Text + "'", cnx);

                    int i = cmd.ExecuteNonQuery();

                    MessageBox.Show("Modification effectuée avec succes!", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    table.Clear();
                    Remplir();
                    Reinitialisation();
                    cnx.Close();
                }
            }

            if (!string.IsNullOrEmpty(nenfant.Text))
            {
                if (b == true)
                {
                    Deconncter();
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("update employee set nbrenfant ='" + nenfant.Text + "' where matricule = '" + getmat.Text + "'", cnx);

                    int i = cmd.ExecuteNonQuery();

                    MessageBox.Show("Modification effectuée avec succes!", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    table.Clear();
                    Remplir();
                    Reinitialisation();
                    cnx.Close();
                }
            }

            if (!string.IsNullOrEmpty(etatc.Text))
            {
                if (b == true)
                {
                    Deconncter();
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("update employee set etatc ='" + etatc.Text + "' where matricule = '" + getmat.Text + "'", cnx);

                    int i = cmd.ExecuteNonQuery();

                    MessageBox.Show("Modification effectuée avec succes!", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    table.Clear();
                    Remplir();
                    Reinitialisation();
                    cnx.Close();
                }
            }

            if (!string.IsNullOrEmpty(adr.Text))
            {
                if (b == true)
                {
                    Deconncter();
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("update employee set adresse ='" + adr.Text + "' where matricule = '" + getmat.Text + "'", cnx);

                    int i = cmd.ExecuteNonQuery();

                    MessageBox.Show("Modification effectuée avec succes!", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    table.Clear();
                    Remplir();
                    Reinitialisation();
                    cnx.Close();
                }
            }

            if (!string.IsNullOrEmpty(numtel.Text))
            {
                if (b == true)
                {
                    Deconncter();
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("update employee set numtel ='" + numtel.Text + "' where matricule = '" + getmat.Text + "'", cnx);

                    int i = cmd.ExecuteNonQuery();

                    MessageBox.Show("Modification effectuée avec succes!", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    table.Clear();
                    Remplir();
                    Reinitialisation();
                    cnx.Close();
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bb_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void getmat_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void numtel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void adresse_Click(object sender, EventArgs e)
        {

        }

        private void month_TextChanged(object sender, EventArgs e)
        {

        }

        private void year_TextChanged(object sender, EventArgs e)
        {

        }

        private void matr_TextChanged(object sender, EventArgs e)
        {

        }

        private void cin_TextChanged(object sender, EventArgs e)
        {

        }

        private void cnam_TextChanged(object sender, EventArgs e)
        {

        }

        private void day_TextChanged(object sender, EventArgs e)
        {

        }

        private void nc_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnc_TextChanged(object sender, EventArgs e)
        {

        }

        private void grade_TextChanged(object sender, EventArgs e)
        {

        }

        private void adr_TextChanged(object sender, EventArgs e)
        {

        }

        private void etatc_TextChanged(object sender, EventArgs e)
        {

        }

        private void nenfant_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}