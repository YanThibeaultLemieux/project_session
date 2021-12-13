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
    public sealed partial class ajoutClient : Page
    {
        public ajoutClient()
        {
            this.InitializeComponent();
            typeClient.Items.Add("Étudiant");
            typeClient.Items.Add("Professeur");
            typeClient.Items.Add("Employé");
        }


        private void EnvoyerClient(object sender, RoutedEventArgs e)
        {
            //Regex regexemail = new Regex();
            Regex regexTelephone = new Regex(@"^[0-9]{10}$");
            Regex regexEmail = new Regex(@"^[a-zA-Z]+\@cegeptr.qc.ca$");

            //if (regexTelephone.IsMatch(telClient.Text) && nomClient.Text != "" && prenomClient.Text != "" &&

            //) ;
            //@nom, @prenom, @email, @telephone, @poste, @bureau, @type

            if (regexTelephone.IsMatch(telClient.Text) && nomClient.Text != "" && prenomClient.Text != "" && regexEmail.IsMatch(emailClient.Text))
            {
                Client client = new Client(null, nomClient.Text, prenomClient.Text,  telClient.Text, posteClient.Text, bureauClient.Text, (String)typeClient.SelectedItem, emailClient.Text);
                gestionDB.getInstance().ajouterClient(client);
                MainPage.listeClients.Add(client);
                this.Frame.Navigate(typeof(listeClient));
            }
            else {
                if (regexTelephone.IsMatch(telClient.Text))
                {
                    telClient.BorderBrush = new SolidColorBrush(Colors.Green);
                    telClient.Foreground = new SolidColorBrush(Colors.Black);
                }
                else {
                    telClient.BorderBrush = new SolidColorBrush(Colors.Red);
                    telClient.Foreground = new SolidColorBrush(Colors.Red);
                    erreurTelephone.Text = "Entrez un numéro au format 1112223333";
                }

                if (nomClient.Text != "") 
                {
                    nomClient.BorderBrush = new SolidColorBrush(Colors.Green);
                    nomClient.Foreground = new SolidColorBrush(Colors.Black);
                }
                else
                {
                    nomClient.BorderBrush = new SolidColorBrush(Colors.Red);
                    nomClient.Foreground = new SolidColorBrush(Colors.Red);
                    erreurNom.Text = "Veuillez entrez une valeur";
                }

                if (prenomClient.Text != "") {
                    prenomClient.BorderBrush = new SolidColorBrush(Colors.Green);
                    prenomClient.Foreground = new SolidColorBrush(Colors.Black);

                }
                else
                {
                    prenomClient.BorderBrush = new SolidColorBrush(Colors.Red);
                    prenomClient.Foreground = new SolidColorBrush(Colors.Red);
                    ErreurPrenom.Text = "Veuillez entrez une valeur";
                }

                if (regexEmail.IsMatch(emailClient.Text))
                {
                    emailClient.BorderBrush = new SolidColorBrush(Colors.Green);
                    emailClient.Foreground = new SolidColorBrush(Colors.Black);
                }
                else {
                    emailClient.BorderBrush = new SolidColorBrush(Colors.Red);
                    emailClient.Foreground = new SolidColorBrush(Colors.Red);
                    ErreurEmail.Text = "Vérifier si votre email a un nom et '@cegeptr.qc.ca' à la fin.";
                }
            }
        }
    }
}
