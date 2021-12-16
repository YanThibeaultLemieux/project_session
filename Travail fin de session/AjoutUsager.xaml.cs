using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Travail_fin_de_session
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AjoutUsager : Page
    {
        public AjoutUsager()
        {
            this.InitializeComponent();
        }

        private void btEnvoyer_Click(object sender, RoutedEventArgs e)
        {

            if (nom.Text == "")
            {
                erreurNom.Text = "Veuillez entrez un nom";
            }
            else erreurNom.Text = "";

            if (usernameBox.Text == "")
            {
                erreurUsername.Text = "Veuillez entrez un nom d'usager";
            }
            else erreurUsername.Text = "";

            if (prenom.Text == "")
            {
                erreurPrenom.Text = "Veuillez entrer un prénom.";
            }
            else erreurPrenom.Text = "";

            if (mdp.Text == "")
            {
                erreurMDP.Text = "Veuillez rentrer un mot de passe.";
            }
            else
                erreurMDP.Text = "";


            if (nom.Text != "" && prenom.Text != "" && usernameBox.Text != "" && mdp.Text != "")
            {
                try 
                {
                    Utilisateurs u = new Utilisateurs(usernameBox.Text, nom.Text, prenom.Text, mdp.Text);

                    gestionDB.getInstance().ajouterUsager(u);
                    MainPage.listeUsers.Add(u);
                    this.Frame.Navigate(typeof(listeUsers));
                
                }
                

                    catch(MySql.Data.MySqlClient.MySqlException)
                {
                    erreurUsername.Text = "Veuillez vous assurez que ce nom d'utilisateur ne soit pas déjà utilisé.";
                }
            }
        }
    }
}
