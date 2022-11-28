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
    public partial class Form3 : Form
    {
        private string connString =
          @"Data Source = .\SQLEXPRESS;Initial Catalog=pubs;Integrated Security=true";
        private SqlConnection connexion;
        private SqlCommand commande;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            connexion = new SqlConnection(connString);
            commande = new SqlCommand();
            commande.Connection = connexion;
        }

        private void buttonAfficher_Click(object sender, EventArgs e)
        {
            commande.CommandText = "last_hiredate";
            commande.CommandType = CommandType.StoredProcedure;

            //Les paramètres
            //IN
            SqlParameter param = new SqlParameter("id_job", SqlDbType.Int);
            param.Value = textBoxCode.Text;
            param.Direction = ParameterDirection.Input;//par défaut

            commande.Parameters.Add(param);

            //OUTPUT
            param = new SqlParameter("date", SqlDbType.DateTime);
            param.Direction = ParameterDirection.Output;

            commande.Parameters.Add(param);

            connexion.Open();
            //execution
            commande.ExecuteReader();
            //recuperer la valeur du parameter OUT
            labelLastDate.Text = param.Value.ToString();
            connexion.Close();



        }
    }
}
