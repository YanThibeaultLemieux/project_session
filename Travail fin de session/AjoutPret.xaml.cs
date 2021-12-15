using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
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
    public sealed partial class AjoutPret : Page
    {
        public AjoutPret()
        {
            this.InitializeComponent();
            

            foreach (Client c in gestionDB.getInstance().getClients())
            {
                idClientComboBox.Items.Add(c.Id);
            }


            foreach (Materiel m in gestionDB.getInstance().getMateriel()) {
                idMatérielComboBox.Items.Add(m.Id);
            }

        }

        private void EnvoyerClient(object sender, RoutedEventArgs e)
        {
            Regex heureRegex = new Regex(@"^[0-9]{2}:[0-9]{2}:[0-9]{2}$");

            var something = datePrêtPicker.Date.DateTime.Year;
            var something2=datePrêtPicker.Date.DateTime.Month;
            var DONOT = datePrêtPicker.Date.DateTime.DayOfWeek;
            var something3= datePrêtPicker.Date.DateTime.Day;


            var haha = dateRemisePicker.Date.DateTime.Year;
            var haha2 = dateRemisePicker.Date.DateTime.Month; 
            var hahanon = dateRemisePicker.Date.DateTime.DayOfWeek;

            var haha3 = dateRemisePicker.Date.DateTime.Day;


            var datecorrecte = something.ToString() + '-' + something2.ToString() + '-' + something3.ToString();
            var datecorrecte2 = haha.ToString() + '-' + haha2.ToString() + '-' + haha3.ToString();

            if (DONOT.ToString() != "Saturday" && DONOT.ToString() != "Sunday" && hahanon.ToString() != "Saturday" && hahanon.ToString() != "Sunday"
                && heureRegex.IsMatch(heureGenerale.Text))
            {
                if (choixHeure.IsChecked == true)
                {
                    pret p = new pret(idClientComboBox.SelectedValue.ToString(), datecorrecte.ToString(), heureGenerale.Text, datecorrecte.ToString(), MainPage.Connecté, "En cours");
                    gestionDB.getInstance().ajouterPret_2(p);
                    MainPage.listePrets.Add(p);



                }
                else if (choixJour.IsChecked == true)
                {
                    pret p = new pret(idClientComboBox.SelectedValue.ToString(), datecorrecte, heureGenerale.Text, datecorrecte2, MainPage.Connecté, "En cours");
                    gestionDB.getInstance().ajouterPret_1(p);
                    MainPage.listePrets.Add(p);

                }




            }
            else if (DONOT.ToString() == "Saturday" || DONOT.ToString() == "Sunday")
                test.Text = "Vous ne pouvez pas emprunter durant la fin de semaine, veuillez choisir une journée entre lundi et vendredi";

            else if (hahanon.ToString() == "Saturday" || hahanon.ToString() == "Sunday")
                test.Text = "Vous ne pouvez pas remettre durant la fin de semaine.";

            else if (heureRegex.IsMatch(heureGenerale.Text)) {
                test.Text = "cool";
            }
            else {
                test.Text = "not cool";
            }
        }
    }
}
