using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Travail_fin_de_session
{
    class gestionDB
    {
        MySqlConnection con;
        static gestionDB gestionOrdinateur = null;

        public gestionDB()
        {
            //this.con = new MySqlConnection("Server=cours.cegep3r.info;Database=a2021_420326ri_equipe_21;Uid=1937041;Pwd=1937041;");
            this.con = new MySqlConnection("Server=localhost;Database=bd_groupe_21_yan;Uid=root;Pwd=root;");

        }

        public static gestionDB getInstance()
        {
            if (gestionOrdinateur == null)
                gestionOrdinateur = new gestionDB();

            return gestionOrdinateur;
        }
            public ObservableCollection<Client> getClients()
            {
                ObservableCollection<Client> liste = new ObservableCollection<Client>();

                MySqlCommand commande = new MySqlCommand();
                commande.Connection = con;
                commande.CommandText = "Select * from client";
                con.Open();
                MySqlDataReader r = commande.ExecuteReader();

                while (r.Read())
                {
                    liste.Add(new Client(r.GetString(0), r.GetString(1), r.GetString(2), r.GetString(3), r.GetString(4), r.GetString(5), r.GetString(6), r.GetString(7)));

                }

                r.Close();
                con.Close();

                return liste;
            }

        public ObservableCollection<Utilisateurs> getUsers()
        {
            ObservableCollection<Utilisateurs> liste = new ObservableCollection<Utilisateurs>();

            MySqlCommand commande = new MySqlCommand();
            commande.Connection = con;
            commande.CommandText = "Select * from Utilisateur";
            con.Open();
            MySqlDataReader r = commande.ExecuteReader();

            while (r.Read())
            {
                liste.Add(new Utilisateurs(r.GetString(0), r.GetString(1), r.GetString(2), r.GetString(3)));

            }

            r.Close();
            con.Close();

            return liste;
        }

        public ObservableCollection<Materiel> getMateriel()
        {
            ObservableCollection<Materiel> listeMat = new ObservableCollection<Materiel>();

            MySqlCommand commande = new MySqlCommand();
            commande.Connection = con;
            commande.CommandText = "Select * from matériel";
            con.Open();
            MySqlDataReader r = commande.ExecuteReader();

            while (r.Read())
            {
                listeMat.Add(new Materiel(r.GetString(0), r.GetString(1), r.GetString(2), r.GetString(3), r.GetString(4), r.GetString(5)));

            }

            r.Close();
            con.Close();

            return listeMat;
        }

        public int Login(Utilisateurs user1) {
            Utilisateurs user = null;

            MySqlCommand commande = new MySqlCommand();
            commande.Connection = con;
            commande.CommandText = "call authentification(@nom_utilisateur, @mdp1)";

            commande.Parameters.AddWithValue("@nom_utilisateur", user1.Nom_utilisateur);
            commande.Parameters.AddWithValue("@mdp1", user1.Motdepasse);
            con.Open();
            
            commande.Prepare();
            MySqlDataReader r = commande.ExecuteReader();
            MainPage.userlogin= new Utilisateurs(user1.Nom_utilisateur, user1.Nom, user1.Prenom, user1.Motdepasse);
            r.Read();
            int estValide = r.GetInt32(0);
            con.Close();
            return estValide;
        }

        public void ajouterClient(Client c) {
            
                MySqlCommand commande = new MySqlCommand();
                commande.Connection = con;
                commande.CommandText = "call ajout_client(@nom, @prenom, @telephone, @poste, @bureau,  @type, @email)";

                commande.Parameters.AddWithValue("@nom", c.Nom);
                commande.Parameters.AddWithValue("@prenom", c.Prenom);
                commande.Parameters.AddWithValue("@telephone", c.Telephone);
                commande.Parameters.AddWithValue("@poste", c.Poste);
                commande.Parameters.AddWithValue("@bureau", c.Bureau);
            commande.Parameters.AddWithValue("@email", c.Email);
            commande.Parameters.AddWithValue("@type", c.Type);
                con.Open();

               commande.Prepare();

            MySqlDataReader r = commande.ExecuteReader();
            con.Close();

           
        }

        public int modifierClient (Client c)
        {
            int retour = 0;
            MySqlCommand commande = new MySqlCommand();
            commande.Connection = con;
            commande.CommandText = "call update_client('@id', '@nom', '@prenom', '@telephone', '@poste', '@bureau', '@type', '@email')";

            commande.Parameters.AddWithValue("@nom", c.Nom);
            commande.Parameters.AddWithValue("@prenom", c.Prenom);
            commande.Parameters.AddWithValue("@email", c.Email);
            commande.Parameters.AddWithValue("@telephone", c.Telephone);
            commande.Parameters.AddWithValue("@poste", c.Poste);
            commande.Parameters.AddWithValue("@bureau", c.Bureau);
            commande.Parameters.AddWithValue("@type", c.Type);
            con.Open();

            commande.Prepare();

            MySqlDataReader r = commande.ExecuteReader();
            con.Close();

            return retour;
        }
        }
    }

