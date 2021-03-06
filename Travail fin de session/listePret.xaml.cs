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
    public sealed partial class listePret : Page
    {
        internal static pret indexPret = new pret();
        public listePret()
        {
            this.InitializeComponent();
            grillePrêt.ItemsSource = MainPage.listePrets;

        }

        private void ajoutMateriel(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AjoutPret));
        }

        private void retournerPret(object sender, RoutedEventArgs e)
        {
            indexPret = (pret)grillePrêt.SelectedItem;
            if (listePret.indexPret is null)
            {
                erreurChoix.Text = "Veuillez sélectionner un prêt à retourner";
            }
            else
            {
            }
        }
    }
}
