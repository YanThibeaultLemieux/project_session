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
    public sealed partial class ModifierUtilisateur : Page
    {
        public ModifierUtilisateur()
        {
            this.InitializeComponent();
            usernameBox.Text = listeUsers.indexUser.Nom_utilisateur;
            nom.Text = listeUsers.indexUser.Nom;
            prenom.Text = listeUsers.indexUser.Prenom;
            mdp.Text = listeUsers.indexUser.Motdepasse;
            if (listeUsers.indexUser.Nom_utilisateur == MainPage.userlogin.Nom_utilisateur)
            {
                mdp.Visibility = Visibility.Visible;
                mdptitre.Visibility = Visibility.Visible;
            }
        }

        private void btEnvoyer_Click(object sender, RoutedEventArgs e)
        {
            if (nom.Text != "" && prenom.Text != "")
            {
                Utilisateurs u = new Utilisateurs(usernameBox.Text, nom.Text, prenom.Text, mdp.Text);
                gestionDB.getInstance().modifierUsager(u);
                this.Frame.Navigate(typeof(listeUsers));
            }
        }
    }
}
