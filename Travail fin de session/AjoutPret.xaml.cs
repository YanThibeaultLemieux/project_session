using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
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
    public sealed partial class AjoutPret : Page
    {
        public AjoutPret()
        {
            this.InitializeComponent();




            foreach (Client c in gestionDB.getInstance().getClients())
            {
                idClientComboBox.Items.Add(c.Id);
            }


            foreach (Materiel m in gestionDB.getInstance().getMateriel())
            {
                idMatérielComboBox.Items.Add(m.Id);
            }

        }

        private void EnvoyerClient(object sender, RoutedEventArgs e)
        {
            Regex heureRegex = new Regex(@"^([0]?[7-9]|^[1]?[0-7]):[0-5][0-9]:[0-5][0-9]");

            var something = datePrêtPicker.Date.DateTime.Year;
            var something2 = datePrêtPicker.Date.DateTime.Month;
            var DONOT = datePrêtPicker.Date.DateTime.DayOfWeek;
            var something3 = datePrêtPicker.Date.DateTime.Day;


            var haha = dateRemisePicker.Date.DateTime.Year;
            var haha2 = dateRemisePicker.Date.DateTime.Month;
            var hahanon = dateRemisePicker.Date.DateTime.DayOfWeek;

            var haha3 = dateRemisePicker.Date.DateTime.Day;


            var datecorrecte = something.ToString() + '-' + something2.ToString() + '-' + something3.ToString();
            var datecorrecte2 = haha.ToString() + '-' + haha2.ToString() + '-' + haha3.ToString();


            var pluspetitimpossible1 = Int32.Parse(something.ToString()) + Int32.Parse(something2.ToString()) + Int32.Parse(something3.ToString());

            var pluspetitimpossible2 = Int32.Parse(haha.ToString()) + Int32.Parse(haha2.ToString()) + Int32.Parse(haha3.ToString());


            if (DONOT.ToString() == "Saturday" || DONOT.ToString() == "Sunday")
            {
                erreur_date.Text = "Vous ne pouvez pas emprunter durant la fin de semaine, veuillez choisir une journée entre lundi et vendredi";
                datePrêtPicker.BorderBrush = new SolidColorBrush(Colors.Red);
                datePrêtPicker.Foreground = new SolidColorBrush(Colors.Red);
            }
            else
            {
                erreur_date.Text = "";
                datePrêtPicker.BorderBrush = new SolidColorBrush(Colors.Green);
                datePrêtPicker.Foreground = new SolidColorBrush(Colors.Black);
            }
            if (hahanon.ToString() == "Saturday" || hahanon.ToString() == "Sunday")
            {
                erreurDateRetour.Text = "Vous ne pouvez pas remettre durant la fin de semaine.";
                dateRemisePicker.BorderBrush = new SolidColorBrush(Colors.Red);
                dateRemisePicker.Foreground = new SolidColorBrush(Colors.Red);
            }
            else
            {
                erreurDateRetour.Text = "";
                dateRemisePicker.BorderBrush = new SolidColorBrush(Colors.Green);
                dateRemisePicker.Foreground = new SolidColorBrush(Colors.Black);
            }
            if (heureRegex.IsMatch(heureGenerale.Text))
            {
                heureGenerale.BorderBrush = new SolidColorBrush(Colors.Green);
                heureGenerale.Foreground = new SolidColorBrush(Colors.Black);
                erreurHeure.Text = "";

            }
            else
            {
                heureGenerale.BorderBrush = new SolidColorBrush(Colors.Red);
                heureGenerale.Foreground = new SolidColorBrush(Colors.Red);
                erreurHeure.Text = "Choisissez un heure entre 07:00:00 et 17:00:00";
            }

            if (pluspetitimpossible1 > pluspetitimpossible2) 
            {
                dateRemisePicker.BorderBrush = new SolidColorBrush(Colors.Red);
                dateRemisePicker.Foreground = new SolidColorBrush(Colors.Red);
                erreurDateRetour.Text = "Impossible de remettre dans le passé";
            }

            if (DONOT.ToString() != "Saturday" && DONOT.ToString() != "Sunday" && hahanon.ToString() != "Saturday" && hahanon.ToString() != "Sunday"
                && heureRegex.IsMatch(heureGenerale.Text))
            {


                if (choixHeure.IsChecked == true)
                {

                    pret p = new pret(0, idClientComboBox.SelectedValue.ToString(), datecorrecte.ToString(), heureGenerale.Text, datecorrecte.ToString(), MainPage.Connecté, "En cours");
                    gestionDB.getInstance().ajouterPret_2(p);
                    //   detailPret dp = new detailPret(p.Id, idMatérielComboBox.SelectedValue.ToString(), 0, MainPage.Connecté);
                    //   gestionDB.getInstance().ajouterDetailPret(dp);
                    MainPage.listePrets.Add(p);
                    //Ajouter à la liste dp
                }
                else if (choixJour.IsChecked == true)
                {

                       
                        pret p = new pret(0, idClientComboBox.SelectedValue.ToString(), datecorrecte, heureGenerale.Text, datecorrecte2, MainPage.Connecté, "En cours"); ;

                        //    detailPret dp = new detailPret(p.Id, idMatérielComboBox.SelectedValue.ToString(), 0, MainPage.Connecté);
                        gestionDB.getInstance().ajouterPret_1(p);
                        //        gestionDB.getInstance().ajouterDetailPret(dp);
                        MainPage.listePrets.Add(p);
                    //Ajouter à la liste dp



                }





            }

        }
    }
}
