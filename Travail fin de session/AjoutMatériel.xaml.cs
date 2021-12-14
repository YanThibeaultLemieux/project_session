using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
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
    public sealed partial class AjoutMatériel : Page
    {
        public AjoutMatériel()
        {
            this.InitializeComponent();
            etatMat.Items.Add("Disponible");
            etatMat.Items.Add("En location");
            etatMat.Items.Add("Défectueux");
            etatMat.Items.Add("En réparation");

        }

        private void btEnvoyer_Click(object sender, RoutedEventArgs e)
        {
            Regex regexID = new Regex(@"^[0-9a-zA-Z]{7}$");

            if (regexID.IsMatch(idMateriel.Text) && marqueMat.Text != "" && modeleMat.Text != "")
            {
                Materiel m = new Materiel(idMateriel.Text, marqueMat.Text, modeleMat.Text, (String)etatMat.SelectedItem, noteMat.Text);
                gestionDB.getInstance().ajouterMatériel(m);
                MainPage.listeMateriels.Add(m);
                this.Frame.Navigate(typeof(ListeMateriel));
            }
            else
            {
                if (regexID.IsMatch(idMateriel.Text))
                {
                    idMateriel.BorderBrush = new SolidColorBrush(Colors.Green);
                    idMateriel.Foreground = new SolidColorBrush(Colors.Black);
                }
                else
                {
                    idMateriel.BorderBrush = new SolidColorBrush(Colors.Red);
                    idMateriel.Foreground = new SolidColorBrush(Colors.Red);
                    erreurID.Text = "Veuillez entrer 7 chiffes et lettres";
                }

                if (marqueMat.Text != "")
                {
                    marqueMat.BorderBrush = new SolidColorBrush(Colors.Green);
                    marqueMat.Foreground = new SolidColorBrush(Colors.Black);
                }
                else
                {
                    marqueMat.BorderBrush = new SolidColorBrush(Colors.Red);
                    marqueMat.Foreground = new SolidColorBrush(Colors.Red);
                    erreurMarque.Text = "une valeure est requise";
                }
                if (modeleMat.Text != "")
                {
                    modeleMat.BorderBrush = new SolidColorBrush(Colors.Green);
                    modeleMat.Foreground = new SolidColorBrush(Colors.Black);
                }
                else
                {
                    modeleMat.BorderBrush = new SolidColorBrush(Colors.Red);
                    modeleMat.Foreground = new SolidColorBrush(Colors.Red);
                    erreurModele.Text = "une valeure est requise";
                }

            }
        }
    }
}
