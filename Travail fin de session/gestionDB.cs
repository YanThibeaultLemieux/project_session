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
        //commentaire
        public gestionDB()
        {
            //this.con = new MySqlConnection("Server=cours.cegep3r.info;Database=a2021_420326ri_equipe_21;Uid=1937041;Pwd=1937041;");
            this.con = new MySqlConnection("Server=localhost;Database=bd_groupe_21;Uid=root;Pwd=root;");
          
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


        public ObservableCollection<Client> getClientsID()
        {
            ObservableCollection<Client> liste = new ObservableCollection<Client>();

            MySqlCommand commande = new MySqlCommand();
            commande.Connection = con;
            commande.CommandText = "Select id from client";
            con.Open();
            MySqlDataReader r = commande.ExecuteReader();

            while (r.Read())
            {
                liste.Add(new Client(r.GetString(0)));

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
                listeMat.Add(new Materiel(r.GetString(0), r.GetString(1), r.GetString(2), r.GetString(3), r.GetString(4)));

            }

            r.Close();
            con.Close();

            return listeMat;
        }

        public ObservableCollection<pret> getPrets() {
            ObservableCollection<pret> listePrets = new ObservableCollection<pret>();

            MySqlCommand commande = new MySqlCommand();
            commande.Connection = con;
            commande.CommandText = "Select * from prêt";
            con.Open();
            MySqlDataReader r = commande.ExecuteReader();

            while (r.Read())
            {

                listePrets.Add(new pret(r.GetInt32(0) , r.GetString(1), r.GetString(2), r.GetString(3), r.GetString(4), r.GetString(5), r.GetString(6)));

            }

            r.Close();
            con.Close();

            return listePrets;
        }



   /*     public ObservableCollection<pret> getPrêtsID()
        {
            ObservableCollection<pret> liste2 = new ObservableCollection<pret>();

            MySqlCommand commande = new MySqlCommand();
            commande.Connection = con;
            commande.CommandText = "SELECT IDENT_CURRENT('prêt')+1";
            con.Open();
            MySqlDataReader r = commande.ExecuteReader();

            while (r.Read())
            {
                liste2.Add(new pret(r.GetInt32(0)));

            }

            r.Close();
            con.Close();

            return liste2;
        }

        */


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

            if (r.Read())
                c.Id = r[0].ToString();

            con.Close();

           
        }



        public void ajouterDetailPret(detailPret dp)
        {

            MySqlCommand commande = new MySqlCommand();
            commande.Connection = con;
            commande.CommandText = "call insert_into_detailPret(@numPrêt, @numMat, @estRetourné, @utilisateur)";

            commande.Parameters.AddWithValue("@numPrêt", dp.IdPret);
            commande.Parameters.AddWithValue("@numMat", dp.IdMat);
            commande.Parameters.AddWithValue("@estRetourné", dp.EstRetourné);
            commande.Parameters.AddWithValue("@utilisateur", dp.Utilisateur);
            con.Open();

            commande.Prepare();

            MySqlDataReader r = commande.ExecuteReader();

            

            con.Close();


        }




        public void ajouterPret_1(pret p)
        {

            MySqlCommand commande = new MySqlCommand();
            commande.Connection = con;
            commande.CommandText = "call ajout_pret(@type, @client, @datepret, @heure, @remise,  @utilisateur, @état)";

            commande.Parameters.AddWithValue("@type", "jour");
            commande.Parameters.AddWithValue("@client", p.IdClient);
            commande.Parameters.AddWithValue("@datepret", p.Date_pret);
            commande.Parameters.AddWithValue("@heure", p.Heure);
            commande.Parameters.AddWithValue("@remise", p.Date_remise);
            commande.Parameters.AddWithValue("@utilisateur", p.Nom_utilisateur);
            commande.Parameters.AddWithValue("@état", p.Etat);
            con.Open();

            commande.Prepare();

            MySqlDataReader r = commande.ExecuteReader();
            con.Close();
        }

        public void ajouterPret_2(pret p)
        {

            MySqlCommand commande = new MySqlCommand();
            commande.Connection = con;
            commande.CommandText = "call ajout_pret(@type, @client, @datepret, @heure, @remise,  @utilisateur, @état)";

            commande.Parameters.AddWithValue("@type", "heure");
            commande.Parameters.AddWithValue("@client", p.IdClient);
            commande.Parameters.AddWithValue("@datepret", p.Date_pret);
            commande.Parameters.AddWithValue("@heure", p.Heure);
            commande.Parameters.AddWithValue("@remise", p.Date_pret);
            commande.Parameters.AddWithValue("@utilisateur", p.Nom_utilisateur);
            commande.Parameters.AddWithValue("@état", p.Etat);
            con.Open();

            commande.Prepare();

            MySqlDataReader r = commande.ExecuteReader();
            con.Close();

        }




        public void ajouterMatériel(Materiel m) {
            MySqlCommand commande = new MySqlCommand();
            commande.Connection = con;
            commande.CommandText = "call ajout_matériel(@id, @marque, @modele, @etat, @note)";

            commande.Parameters.AddWithValue("@id", m.Id);
            commande.Parameters.AddWithValue("@marque", m.Marque);
            commande.Parameters.AddWithValue("@modele", m.Modèle);
            commande.Parameters.AddWithValue("@etat", m.État);
            commande.Parameters.AddWithValue("@note", m.Note);
           
            con.Open();

            commande.Prepare();

            MySqlDataReader r = commande.ExecuteReader();

            if (r.Read())
                m.Id = r[0].ToString();

            con.Close();
        }

        public void modifierClient (Client c)
        {
            MySqlCommand commande = new MySqlCommand();
            commande.Connection = con;
            commande.CommandText = "update_client";
            commande.CommandType = System.Data.CommandType.StoredProcedure;
            commande.Parameters.AddWithValue("id_client", c.Id);
            commande.Parameters.AddWithValue("unnom", c.Nom);
            commande.Parameters.AddWithValue("unprenom", c.Prenom);
            commande.Parameters.AddWithValue("unemail", c.Email);
            commande.Parameters.AddWithValue("untelephone", c.Telephone);
            commande.Parameters.AddWithValue("unposte", c.Poste);
            commande.Parameters.AddWithValue("unbureau", c.Bureau);
            commande.Parameters.AddWithValue("untype", c.Type);
            con.Open();

            commande.Prepare();

            MySqlDataReader r = commande.ExecuteReader();

            if (r.Read())
                c.Id = r[0].ToString();
            con.Close();

        }



        public void modifierMatériel(Materiel m)
        {
            MySqlCommand commande = new MySqlCommand();
            commande.Connection = con;
            commande.CommandText = "update_Matériel";
            commande.CommandType = System.Data.CommandType.StoredProcedure;
            commande.Parameters.AddWithValue("id_mat", m.Id);
            commande.Parameters.AddWithValue("marque1", m.Marque);
            commande.Parameters.AddWithValue("modèle1", m.Modèle);
            commande.Parameters.AddWithValue("état1", m.État);
            commande.Parameters.AddWithValue("note1", m.Note);

            con.Open();

            commande.Prepare();

            MySqlDataReader r = commande.ExecuteReader();

           
            con.Close();

        }



    }
    }

