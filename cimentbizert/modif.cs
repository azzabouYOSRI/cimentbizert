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
            Remplir(4);
        }
        DataTable table = new DataTable();
        SqlDataReader Reader;

        public void Reinitialisation()
        {
            name.Clear();
            pname.Clear();
            mat.Clear();
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



        public void Remplir(int x)
        {


            Deconncter();
            cnx.Open();

            if (x == 1)
            {
                cmd = new SqlCommand("select * from employee WHERE matricule = '" + getmat.Text + "'", cnx);
            }
            else if (x == 2)
            {
                cmd = new SqlCommand("select * from bulletin WHERE employ  = ", cnx);

            }
            else if (x == 3)
            {
                cmd = new SqlCommand("select * from bulletin WHERE agent   = ", cnx);

            }
            else if (x == 4)
            {
                cmd = new SqlCommand("select * from employee ", cnx);
            }

            Reader = cmd.ExecuteReader();
            table.Load(Reader);
            dataGridView1.DataSource = table;
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }

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
                Remplir(1);
                Reinitialisation();
                cnx.Close();
                b = true;

            }

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

            
            

            if (!string.IsNullOrEmpty(name.Text))
            {
                
                    Deconncter();
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("update employee set nom='" + name.Text + "' where matricule = '" + getmat.Text + "'", cnx);

                    int i = cmd.ExecuteNonQuery();

                    MessageBox.Show("Modification effectuée avec succes!", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    table.Clear();
                    Remplir(4);
                    Reinitialisation();
                    cnx.Close();
                
            }

            if (!string.IsNullOrEmpty(pname.Text))
            {
                
                    Deconncter();
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("update employee set prenom='" + pname.Text + "' where matricule = '" + getmat.Text + "'", cnx);

                    int i = cmd.ExecuteNonQuery();

                    MessageBox.Show("Modification effectuée avec succes!", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    table.Clear();
                    Remplir(4);
                    Reinitialisation();
                    cnx.Close();
                
            }

            if (!string.IsNullOrEmpty(cin.Text))
            {
                    Deconncter();
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("update employee set cname='" + cnam.Text + "' where matricule = '" + getmat.Text + "'", cnx);

                    int i = cmd.ExecuteNonQuery();

                    MessageBox.Show("Modification effectuée avec succes!", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    table.Clear();
                    Remplir(4);
                    Reinitialisation();
                    cnx.Close();
                
            }

            if (!string.IsNullOrEmpty(year.Text) && !string.IsNullOrEmpty(month.Text) && !string.IsNullOrEmpty(day.Text))
            {
                
                    Deconncter();
                    cnx.Open();
                    string date = year.Text + "-" + month.Text + "-" + day.Text;
                    SqlCommand cmd = new SqlCommand("update employee set datenais ='" + date + "' where matricule = '" + getmat.Text + "'", cnx);

                    int i = cmd.ExecuteNonQuery();

                    MessageBox.Show("Modification effectuée avec succes!", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    table.Clear();
                    Remplir(4);
                    Reinitialisation();
                    cnx.Close();
                
            }

            if (!string.IsNullOrEmpty(nc.Text))
            {
                    Deconncter();
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("update employee set nomcon ='" + nc.Text + "' where matricule = '" + getmat.Text + "'", cnx);

                    int i = cmd.ExecuteNonQuery();

                    MessageBox.Show("Modification effectuée avec succes!", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    table.Clear();
                    Remplir(4);
                    Reinitialisation();
                    cnx.Close();
                
            }

            if (!string.IsNullOrEmpty(pnc.Text))
            {
                    Deconncter();
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("update employee set prenomcon ='" + pnc.Text + "' where matricule = '" + getmat.Text + "'", cnx);

                    int i = cmd.ExecuteNonQuery();

                    MessageBox.Show("Modification effectuée avec succes!", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    table.Clear();
                    Remplir(4);
                    Reinitialisation();
                    cnx.Close();
                
            }

            if (!string.IsNullOrEmpty(grade.Text))
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
                    Remplir(4);
                    Reinitialisation();
                    cnx.Close();
                
            }

            if (!string.IsNullOrEmpty(nenfant.Text))
            {
                
                    Deconncter();
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("update employee set nbrenfant ='" + nenfant.Text + "' where matricule = '" + getmat.Text + "'", cnx);

                    int i = cmd.ExecuteNonQuery();

                    MessageBox.Show("Modification effectuée avec succes!", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    table.Clear();
                    Remplir(4);
                    Reinitialisation();
                    cnx.Close();
                
            }

            if (!string.IsNullOrEmpty(etatc.Text))
            {
                
                    Deconncter();
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("update employee set etatc ='" + etatc.Text + "' where matricule = '" + getmat.Text + "'", cnx);

                    int i = cmd.ExecuteNonQuery();

                    MessageBox.Show("Modification effectuée avec succes!", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    table.Clear();
                    Remplir(4);
                    Reinitialisation();
                    cnx.Close();
                
            }

            if (!string.IsNullOrEmpty(adr.Text))
            {
                
                    Deconncter();
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("update employee set adresse ='" + adr.Text + "' where matricule = '" + getmat.Text + "'", cnx);

                    int i = cmd.ExecuteNonQuery();

                    MessageBox.Show("Modification effectuée avec succes!", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    table.Clear();
                    Remplir(4);
                    Reinitialisation();
                    cnx.Close();
                
            }

            if (!string.IsNullOrEmpty(numtel.Text))
            {
                   Deconncter();
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("update employee set numtel ='" + numtel.Text + "' where matricule = '" + getmat.Text + "'", cnx);

                    int i = cmd.ExecuteNonQuery();

                    MessageBox.Show("Modification effectuée avec succes!", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    table.Clear();
                    Remplir(4);
                    Reinitialisation();
                    cnx.Close();
                
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

        private void button1_Click(object sender, EventArgs e)
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
                SqlCommand cmd = new SqlCommand("delete from employee where matricule='" + mat.Text + "'", cnx);

                int i = cmd.ExecuteNonQuery();

                MessageBox.Show("Modification effectuée avec succes!", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reinitialisation();
                cnx.Close();
                b = true;
                table.Clear();

                Remplir(4);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nom = name.Text;
            string prenom = pname.Text;
            string matt = mat.Text;
            string idn = cin.Text;
            string codec = cnam.Text;
            string datenais = year.Text + "-" + month.Text + "-" + day.Text;
            string nconj = nc.Text;
            string pconj = pnc.Text;
            string grad = grade.Text;
            string nbrenf = nenfant.Text;
            string ecivil = etatc.Text;
            string adress = adr.Text;
            string numt = numtel.Text;
            float solde;
            bool erreur = false;
            int matt1;
            int idn1;
            int codec1;
            int grad1;
            int nbrenf1;
            int numt1;
            bool b = true;
            if (nom == "" || prenom == "" || matt == "" || idn == "" || codec == "" || datenais == "" || nconj == "" || grad == "" || nbrenf == "" || ecivil == "" || adress == "" || numt == "" || matt == "")
            {
                erreur = true;
                MessageBox.Show("Veuillez remplir tous les champs de la formulaire", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(matt, out matt1) || !int.TryParse(idn, out idn1) || !int.TryParse(codec, out codec1) || !int.TryParse(grad, out grad1) || !int.TryParse(nbrenf, out nbrenf1) || !int.TryParse(numt, out numt1))
            {

                erreur = true;
                MessageBox.Show("Veuillez vérifier les valeurs saisis", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else if (Trouver() != 0)
            {
                MessageBox.Show("Ce numéro de facture déja existe!", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if ((!erreur) && (Trouver() == 0) && (b == true))
            {
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

                SqlCommand cmd = new SqlCommand
                {
                    Connection = cnx
                };
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into employee(matricule,cin,nom,prenom,adresse,etatc,grade,nomcon,prenomcon,numtel,ccname,nbrenfant,datenais,solde) values ( '" + matt + "', '" + idn + "', '" + nom + "', '" + prenom + "', '" + adress + "', '" + ecivil + "', '" + grad + "', '" + nconj + "', '" + pconj + "', '" + numt + "', '" + codec + "','" + nbrenf + "', '" + datenais + "', '" + solde + "')";
                int i = cmd.ExecuteNonQuery();

                if (i != 0)
                {


                    MessageBox.Show("Ajout effectué avec succes!", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else

                    MessageBox.Show("Probléme d'insertion", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cnx.Close();
                Reinitialisation();
            }
            table.Clear();

            Remplir(4);



        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (Trouver() == 0)
            {
                MessageBox.Show("Ce numéro d'agent n'existe pas!", "Attention",
       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Deconncter();
                cnx.Open();
                table.Clear();
                Remplir(3);
                Reinitialisation();
                cnx.Close();
                b = true;

            }
        }

        private void consulteremp_Click(object sender, EventArgs e)
        {
            if (Trouver() == 0)
            {
                MessageBox.Show("Ce numéro de matricule n'existe pas!", "Attention",
       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Deconncter();
                cnx.Open();
                Remplir(2);
                Reinitialisation();
                cnx.Close();
                b = true;

            }
        }

        private void supp_Click(object sender, EventArgs e)
        {
            int j = 0;
            int month;
            double sommes = 0;
            int year = int.Parse(years.Text);
            if (!string.IsNullOrEmpty(months.Text))
            {
                j = int.Parse(months.Text);
                month = 1;
            }
            else
            {
                month = 12;
            }
            do
            {
                j++;

                int numDays = 0;
                switch (j)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        numDays = 31;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        numDays = 30;
                        break;
                    case 2:
                        if (((year % 4 == 0) &&
                             !(year % 100 == 0))
                             || (year % 400 == 0))
                            numDays = 29;
                        else
                            numDays = 28;
                        break;
                }
                for (int i = 0; i < numDays; i++)
                {
                    double x = 0;
                    Deconncter();
                    cnx.Open();
                    string my = "select frais  from bulletin WHERE matricule = '" + year + "' -'" + j + "' -'" + i + "'";
                    cmd = new SqlCommand(my, cnx);
                    x = Convert.ToDouble(cmd.ExecuteScalar());
                    cnx.Close();
                    sommes = sommes + (x * 0.3);
                }

            } while (j <= month);
        }
    }
}