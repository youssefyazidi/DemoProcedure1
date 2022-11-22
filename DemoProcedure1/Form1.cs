using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoProcedure1
{
    public partial class Form1 : Form
    {
        private string connString =
           @"Data Source = .\SQLEXPRESS;Initial Catalog=pubs;Integrated Security=true";
        private SqlConnection connexion;
        private SqlCommand commande;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connexion = new SqlConnection(connString);
            commande = new SqlCommand();
            commande.Connection = connexion;
        }

        private void buttonAfficherTitles_Click(object sender, EventArgs e)
        {
            //Appel de procedure sans paramètres
            string appel = "sp_tiltles_with_price";
            commande.CommandText = appel;
            //il s'agit d'un appel de procedure
            commande.CommandType = CommandType.StoredProcedure;

            connexion.Open();

            SqlDataReader reader=commande.ExecuteReader();
            textBoxTitles.Text=
                String.Format("{0,10}  {1,10}  {2,10}\r\n",
                "pub_id", "title_id", "price");
            while (reader.Read())
            {
                textBoxTitles.Text+=
                String.Format("{0,10}  {1,10}  {2,10}\r\n", 
                reader[0], 
                reader[1], 
                reader[2]);
            }
             
            reader.Close();
            connexion.Close();
        }
    }
}
