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
using System.Data.OleDb;
using System.Globalization;
// using System.Globalization;

namespace cimentbizert
{
    public partial class test : Form
    {


        SqlConnection cnx = new SqlConnection
        {
            ConnectionString = @"Data Source=yosri;Initial Catalog=CLIMENTb;Integrated Security=True"
        };
        SqlCommand cmd = new SqlCommand();
        public void Deconncter()
        {
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
        }

        public Boolean alpahbet(string ch)
        {
            Boolean bolb = true;
            int i=0;
            do
            {
                if (!char.IsLetter(ch[i])) { bolb = false; }
                else { i++; }   
            } while (i+1 < ch.Length && bolb);
            return bolb;
        }

        DataTable table = new DataTable();
        DataTable table2 = new DataTable();
        SqlDataReader Reader;




        public void Remplir(int x)
        {
            Deconncter();
            cnx.Open();

            if (x == 1)
            {
                cmd = new SqlCommand("select * from employee WHERE matricule = '" + getmat.Text + "' ", cnx);
                Reader = cmd.ExecuteReader();
                table.Load(Reader);
                dataGridView1.DataSource = table;
            }
            else if (x == 2)
            {
                cmd = new SqlCommand("select * from bulletin WHERE employ  =  '" + getmat.Text + "'", cnx);
                Reader = cmd.ExecuteReader();
                table2.Load(Reader);
                dataGridView1.DataSource = table2;

            }
            else if (x == 3)
            {
                cmd = new SqlCommand("select * from bulletin WHERE agent   = '" + getmat.Text + "' ", cnx);
                Reader = cmd.ExecuteReader();
                table2.Load(Reader);
                dataGridView1.DataSource = table2;

            }
            else if (x == 4)
            {
                cmd = new SqlCommand("select * from employee ", cnx);
                Reader = cmd.ExecuteReader();
                table.Load(Reader);
                dataGridView1.DataSource = table;
            }


            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
        }

        public test()
        {
            InitializeComponent();
            Remplir(4);
        }



        public int Trouver(int y)
        {
            int x = 0;
            Deconncter();
            cnx.Open();

            if (y == 1)
            {
                cmd = new SqlCommand("select count(*) from employee WHERE matricule = '" + getmat.Text + "' ", cnx);
            }
            else if (y == 2)
            {
                cmd = new SqlCommand("select count(*) from bulletin WHERE employ  =  '" + getmat.Text + "'", cnx);

            }
            else if (y == 3)
            {
                cmd = new SqlCommand("select (*) from bulletin WHERE agent   = '" + getmat.Text + "' ", cnx);

            }

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void consulteremp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(getmat.Text))
            {
                MessageBox.Show(" champ ne peut pas etre vide !", "Attention",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Trouver(2) == 0)
                {
                    MessageBox.Show("Ce numéro de matricule n'existe pas!", "Attention",
           MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    Deconncter();
                    cnx.Open();
                    table.Clear();
                    Remplir(2);
                    Reinitialisation();
                    cnx.Close();
                    //b = true;

                }

            }
        }

        private void consulteragent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(getmat.Text))
            {
                MessageBox.Show(" champ ne peut pas etre vide !", "Attention",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Trouver(2) == 0)
                {
                    MessageBox.Show("Ce numéro d'agent n'existe pas!", "Attention",
           MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    Deconncter();
                    cnx.Open();
                    table.Clear();
                    Remplir(2);
                    Reinitialisation();
                    cnx.Close();
                    //b = true;

                }
            }
        }

        private void getbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(getmat.Text))
            {
                MessageBox.Show(" champ ne peut pas etre vide !", "Attention",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (Trouver(1) == 0)
                {
                    MessageBox.Show("Cete matricule n'existe pas!", "Attention",
           MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    Deconncter();
                    cnx.Open();
                    table.Clear();
                    Remplir(1);
                    Reinitialisation();
                    cnx.Close();
                    //b = true;

                }

            }
        }

        private void ajouter_Click(object sender, EventArgs e)
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
            DateTime dt;

            if (nom == "" || prenom == "" || matt == "" || idn == "" || codec == "" || datenais == "" || nconj == "" || grad == "" || nbrenf == "" || ecivil == "" || adress == "" || numt == "" || matt == "")
            {
                erreur = true;
                MessageBox.Show("Veuillez remplir tous les champs de la formulaire", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(matt, out matt1) || !int.TryParse(idn, out idn1) || !int.TryParse(codec, out codec1) || !int.TryParse(grad, out grad1) || !int.TryParse(nbrenf, out nbrenf1) || !int.TryParse(numt, out numt1)
                || !alpahbet(nom) || !alpahbet(prenom) || !alpahbet(nconj) || !alpahbet(pconj) || !alpahbet(ecivil) || !alpahbet(adress) || !DateTime.TryParse(datenais, out dt))
            {

                erreur = true;
                MessageBox.Show("Veuillez vérifier les valeurs saisis", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else if (Trouver(1) != 0)
            {
                MessageBox.Show("matricule déja existe!", "Attention",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if ((!erreur) && (Trouver(1) == 0) && (b == true))
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

            if (Trouver(1) == 0)
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
                // b = true;

            }


        }

        private void suprimer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(getmat.Text))
            {
                MessageBox.Show(" champ ne peut pas etre vide !", "Attention",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (Trouver(1) == 0)
                {
                    MessageBox.Show("Ce numéro de matricule n'existe pas!", "Attention",
           MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    Deconncter();
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("delete from employee where matricule='" + getmat.Text + "'", cnx);

                    int i = cmd.ExecuteNonQuery();

                    MessageBox.Show("supression effectuée avec succes!", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reinitialisation();
                    cnx.Close();
                    //b = true;
                    table.Clear();
                    Remplir(4);
                }
            }


        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            int idn1;
            int codec1;
            int grad1;
            int nbrenf1;
            int numt1;
            DateTime dt;
            if (string.IsNullOrEmpty(getmat.Text))
            {
                MessageBox.Show(" champ ne peut pas etre vide !", "Attention",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Trouver(1) == 0)
                {
                    MessageBox.Show("Cet employee n'existe pas", "Attention",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else { 

                if (!string.IsNullOrEmpty(name.Text))
                {
                        if (!alpahbet(name.Text))
                        {
                            MessageBox.Show("Ce champ accept les chaines unisuement", "Attention",
        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
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
                }

                if (!string.IsNullOrEmpty(pname.Text))
                {
                        if (!alpahbet(pname.Text))
                        {
                            MessageBox.Show("Ce champ accept les chaines unisuement", "Attention",
        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
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

                }

                if (!string.IsNullOrEmpty(cin.Text))
                {
                        if (!int.TryParse(cin.Text, out idn1))
                        {
                            MessageBox.Show("Ce champ accept les chiifre unisuement", "Attention",
        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
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
                }
                    string datenais = year.Text + "-" + month.Text + "-" + day.Text;

                    if (!string.IsNullOrEmpty(year.Text) && !string.IsNullOrEmpty(month.Text) && !string.IsNullOrEmpty(day.Text))
                {
                        if (!DateTime.TryParse(datenais, out dt))
                        {
                            MessageBox.Show("Ce champ accept les chiifre unisuement", "Attention",
        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
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
                }

                if (!string.IsNullOrEmpty(nc.Text))
                {
                        if (!alpahbet(nc.Text))
                        {
                            MessageBox.Show("Ce champ accept les chaines unisuement", "Attention",
        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
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
                }

                if (!string.IsNullOrEmpty(pnc.Text))
                {
                        if (!alpahbet(pnc.Text))
                        {
                            MessageBox.Show("Ce champ accept les chaines unisuement", "Attention",
        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
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
                }

                    if (!string.IsNullOrEmpty(grade.Text))
                    {
                        if (!int.TryParse(grade.Text, out grad1))
                        {
                            MessageBox.Show("Ce champ accept les chiifre unisuement", "Attention",
        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
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
                    }

                    if (!string.IsNullOrEmpty(nenfant.Text))
                    {
                        if (!int.TryParse(nenfant.Text, out nbrenf1))
                        {
                            MessageBox.Show("Ce champ accept les chiifre unisuement", "Attention",
        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
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
                    }

                if (!string.IsNullOrEmpty(etatc.Text))
                {
                        if (!alpahbet(etatc.Text))
                        {
                            MessageBox.Show("Ce champ accept les chaines unisuement", "Attention",
        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
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
                }

                if (!string.IsNullOrEmpty(adr.Text))
                {
                        if (!alpahbet(adr.Text))
                        {
                            MessageBox.Show("Ce champ accept les chaines unisuement", "Attention",
        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
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
                }

                    if (!string.IsNullOrEmpty(numtel.Text))
                    {
                        if (!int.TryParse(numtel.Text, out numt1))
                        {
                            MessageBox.Show("Ce champ accept les chiifre unisuement", "Attention",
        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
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

                    if (!string.IsNullOrEmpty(cnam.Text))
                    {
                        if (!int.TryParse(cnam.Text, out codec1))
                        {
                            MessageBox.Show("Ce champ accept les chiifre uniquement", "Attention",
        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Deconncter();
                            cnx.Open();
                            SqlCommand cmd = new SqlCommand("update employee set numtel ='" + cnam.Text + "' where matricule = '" + getmat.Text + "'", cnx);

                            int i = cmd.ExecuteNonQuery();

                            MessageBox.Show("Modification effectuée avec succes!", "Bravo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            table.Clear();
                            Remplir(4);
                            Reinitialisation();
                            cnx.Close();
                        }
                    }

                }

            }
        }

        private void supp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CALC.Text))
            {
                MessageBox.Show(" champ ne peut pas etre vide !", "Attention",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { 
            string x = "";
            float value;
            int j = 0;
            int month;
            double sommes = 0;
            string sdate;
            int year = int.Parse(year_somme.Text);
            if (!string.IsNullOrEmpty(months.Text))
            {
                j = int.Parse(months.Text);
                month = 1;
                MessageBox.Show("feragh", "Attention",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                month = 12;
                MessageBox.Show("m3abi", "Attention",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

                DataTable table_raw = new DataTable();
                cnx.Open();
                DateTime date = DateTime.ParseExact(year_somme.Text, "yyyy", CultureInfo.InvariantCulture);
                string dt2 = date.ToString("yyyy");
                cmd = new SqlCommand("select frais from bulletin where year(date_Depot)= '" + dt2 + "'", cnx);
                Reader = cmd.ExecuteReader();
                table_raw.Load(Reader);
                //dataGridView1.DataSource = table_raw;
                Decimal Totalfrais = Convert.ToDecimal(table.Compute("SUM(frais)", string.Empty));


               x = Convert.ToString(Totalfrais);
            resultset.Text = x;
        }
    }


        private void resultcalc_TextChanged(object sender, EventArgs e)
        {

        }

        private void etatc_TextChanged(object sender, EventArgs e)
        {

        }

        private void getmat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

