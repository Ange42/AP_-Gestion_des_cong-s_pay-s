using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Partie_back_office_Gestion_des_congés_payés
{
    public partial class PageConnexion : Form
    {
        //Voici mon constructeur pour 
            private MySqlConnection pageconnection;
            private string server;
            private string database;
            private string uid;
            private string password;


        public PageConnexion()
        {
            InitializeComponent();

        }
        private void Initialise()
        {
            server = "localhost";
            database = "bdd_concession";
            uid = "root";
            password = "";
            string pageconnectionString;
            pageconnectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            pageconnection = new MySqlConnection(pageconnectionString);
        }
 

        
    }
}
