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

namespace cimentbizert
{
    public partial class listemp : Form
    {
        public listemp()
        {
            InitializeComponent();
            Remplir();

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

        public void Remplir()
        {
            Deconncter();
            cnx.Open();
            cmd = new SqlCommand("select * from employee ", cnx);
            Reader = cmd.ExecuteReader();
            table.Load(Reader);
            dataGridView1.DataSource = table;
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
