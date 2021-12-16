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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Travail_fin_de_session
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ModifierMateriel : Page
    {
        public ModifierMateriel()
        {
            this.InitializeComponent();

            idMateriel.Text = ListeMateriel.indexMat.Id;
            marqueMat.Text = ListeMateriel.indexMat.Marque;
            etatMat.Items.Add(ListeMateriel.indexMat.État);
            modeleMat.Text = ListeMateriel.indexMat.Modèle;
            noteMat.Text = ListeMateriel.indexMat.Note;

            etatMat.Items.Add("En location");
            etatMat.Items.Add("Défectueux");
            etatMat.Items.Add("En réparation");






        }

        private void btEnvoyer_Click(object sender, RoutedEventArgs e)
        {


            if (marqueMat.Text != "" && modeleMat.Text != "")
            {

                Materiel m = new Materiel(idMateriel.Text, marqueMat.Text, modeleMat.Text, (String)etatMat.SelectedItem, noteMat.Text);
                gestionDB.getInstance().modifierMatériel(m);
          
                
                MainPage.listeMateriels.Add(m);
                MainPage.listeMateriels.Remove(ListeMateriel.indexMat);

                this.Frame.Navigate(typeof(ListeMateriel));
            }
            else
            {

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
