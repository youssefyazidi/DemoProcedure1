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
    public partial class Form2 : Form
    {
        private string connString =
           @"Data Source = .\SQLEXPRESS;Initial Catalog=pubs;Integrated Security=true";
        private SqlConnection connexion;
        private SqlCommand commande;
        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            connexion = new SqlConnection(connString);
            commande = new SqlCommand();
            commande.Connection = connexion;
        }



        private void buttonAfficherTitles_Click(object sender, EventArgs e)
        {
            //Appel de procedure avce des paramètres in (entrees)
            string appel = "sp_titles_price_betwenn";
            commande.CommandText = appel;
            //il s'agit d'un appel de procedure
            commande.CommandType = CommandType.StoredProcedure;

            //Il faut définir les paramètres
            SqlParameter param = new SqlParameter("lolimit",SqlDbType.Money);
            param.Value = textBoxPrixMin.Text;
            commande.Parameters.Add(param);

            param = new SqlParameter("hilimit", SqlDbType.Money);
            param.Value = textBoxPrixMax.Text;
            commande.Parameters.Add(param);

            param = new SqlParameter("type", SqlDbType.VarChar);
            param.Value = textBoxTypeEdition.Text;
            commande.Parameters.Add(param);

            connexion.Open();

            SqlDataReader reader = commande.ExecuteReader();
            textBoxTitles.Text =
                String.Format("{0,10}  {1,10}  {2,10}\r\n",
                "pub_id", "title_id", "price");
            while (reader.Read())
            {
                textBoxTitles.Text +=
                String.Format("{0,10}  {1,10}  {2,10}\r\n",
                reader[0],
                reader[1],
                reader[2]);
            }

            reader.Close();
            connexion.Close();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTypeEdition_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
