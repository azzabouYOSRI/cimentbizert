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

    public partial class ajt : Form
    {
        public ajt()
        {
            InitializeComponent();

        }
        SqlConnection cnx = new SqlConnection
        {
            ConnectionString = @"Data Source=yosri;Initial Catalog=ciment;Integrated Security=True"
        };
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
            string my= "select count(*) from employee WHERE matricule = '" + mat.Text + "'";
             cmd = new SqlCommand(my, cnx);
        x = Convert.ToInt32(cmd.ExecuteScalar());
            cnx.Close();
            return x;
        }




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




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void ajoutbtn_Click(object sender, EventArgs e)
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
            else if ( !int.TryParse(matt, out matt1) || !int.TryParse(idn, out idn1) || !int.TryParse(codec, out codec1) || !int.TryParse(grad, out grad1) || !int.TryParse(nbrenf, out nbrenf1) || !int.TryParse(numt, out numt1))
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
                cmd.CommandText = "insert into employee(matricule,cin,nom,prenom,adresse,etatc,grade,nomcon,prenomcon,numtel,ccname,datenais,solde) values ( '" + matt + "', '" + idn + "', '" + nom  + "', '" + prenom  + "', '" + adress + "', '" + ecivil  + "', '" + grad  + "', '" +nconj  + "', '" +pconj  + "', '" + numt  + "', '" + codec  + "', '" + datenais + "', '" + solde  + "')";
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
            
            


    }



    private void etatc_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new modif()).Show();
        }
    }


        

     
}

