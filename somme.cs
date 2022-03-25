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
    public partial class somme : Form
    {
        public somme()
        {
            InitializeComponent();
        }

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
        public void Reinitialisation()
        {


        }


        private void SU1_TextChanged(object sender, EventArgs e)
        {

        }

        private void supp_Click(object sender, EventArgs e)
        {
            int j= 0;
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

            int numDays =0;
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
                sommes =sommes + (x*0.3);
            }

            } while (j <= month);

        }
    }
}
