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

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=234238

namespace Travail_fin_de_session
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>        

    public sealed partial class listeUsers : Page
    {
        internal static Utilisateurs indexUser = new Utilisateurs();

        public listeUsers()
        {
            this.InitializeComponent();
            grilleUtilisateurs.ItemsSource = MainPage.listeUsers;
        }

        private void AjouteerUser_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AjoutUsager));

        }

        private void btEnvoyer_Click(object sender, RoutedEventArgs e)
        {
            indexUser = (Utilisateurs)grilleUtilisateurs.SelectedItem;
            if (listeUsers.indexUser is null)
            {
                erreurChoix.Text = "Veuillez sélectionner un matériel à modifier";
            }
            else
            {
                this.Frame.Navigate(typeof(ModifierUtilisateur));
            }
            
        }
    }
}
