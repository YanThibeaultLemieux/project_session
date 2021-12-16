using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=234238

namespace Travail_fin_de_session
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class listeClient : Page
    {

        internal static Client indexClient = new Client();
        public listeClient()
        {
            this.InitializeComponent();
            grilleNom.ItemsSource = MainPage.listeClients;
        }

        private void Ajouter_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ajoutClient));

        }

        private void Modifier_Click(object sender, RoutedEventArgs e)
        {

            indexClient = (Client)grilleNom.SelectedItem;
            if (listeClient.indexClient is null)
            {
                erreurPick.Text = "Veuillez sélectionner un client à modifier";
            }
            else {

                this.Frame.Navigate(typeof(modifierClient));

            }

        }

        private void Rechercher_Bouton_Click(object sender, RoutedEventArgs e)
        {


            if (Rechercher_Entry.Text == "") {
                résultat.Text = "Veuillez entrez un numéro de téléphone ou ID.";
            }

            else {
                  grilleNom.ItemsSource   = gestionDB.getInstance().rechercheClient(Rechercher_Entry.Text);


                


            }
        }
    }
}
