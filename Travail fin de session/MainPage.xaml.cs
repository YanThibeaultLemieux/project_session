using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Travail_fin_de_session
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        internal static ObservableCollection<Client> listeClients = gestionDB.getInstance().getClients();
        internal static ObservableCollection<Materiel> listeMateriels = gestionDB.getInstance().getMateriel();
        internal static ObservableCollection<Utilisateurs> listeUsers = gestionDB.getInstance().getUsers();
        internal static ObservableCollection<pret> listePrets = gestionDB.getInstance().getPrets();
        internal static string Connecté;
        internal static Utilisateurs userlogin;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btLogin_Click(object sender, RoutedEventArgs e)
        {
            Utilisateurs user = new Utilisateurs();
            
            user.Motdepasse = motdepasse.Text;
            user.Nom_utilisateur = nomUtilisateur.Text;

            if (gestionDB.getInstance().Login(user) == 1)
            {
                this.Frame.Navigate(typeof(bar));
                Connecté = user.Nom_utilisateur;
            }
            else
            {
                ERREURLOGIN.Text = "Erreur de connection";
            }
        }
    }
}
