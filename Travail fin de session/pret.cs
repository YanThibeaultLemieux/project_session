using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Travail_fin_de_session
{
    class pret
    {
        int id;
        string idClient;
        string date_pret;
        string heure;
        string date_remise;
        string nom_utilisateur;
        string etat;

        public int Id { get => id; 
            set {  id = value; this.OnPropertyChanged(); } }
        public string IdClient { get => idClient;
            set {  idClient = value;
                this.OnPropertyChanged();
            } }
        public string Date_pret { get => date_pret;
            set {  date_pret = value; this.OnPropertyChanged(); } }
        public string Heure { get => heure; 
            set {  heure = value; this.OnPropertyChanged(); } }
        public string Date_remise { get => date_remise; 
            set {  date_remise = value; this.OnPropertyChanged(); } }
        public string Nom_utilisateur { get => nom_utilisateur; 
            set {  nom_utilisateur = value; this.OnPropertyChanged(); } }
        public string Etat { get => etat; 
            set {  etat = value; this.OnPropertyChanged(); } }

        public pret(int id, string idClient, string date_pret, string heure, string date_remise, string nom_utilisateur, string etat)
        {
            this.id = id;
            this.idClient = idClient;
            this.date_pret = date_pret;
            this.heure = heure;
            this.date_remise = date_remise;
            this.nom_utilisateur = nom_utilisateur;
            this.etat = etat;
        }

        public pret()
        {
            this.id = 0;
            this.idClient = "";
            this.date_pret = "";
            this.heure = "";
            this.date_remise = "";
            this.nom_utilisateur = "";
            this.etat = "";
        }

        public override bool Equals(object obj)
        {
            return obj is pret pret &&
                   id == pret.id &&
                   idClient == pret.idClient &&
                   date_pret == pret.date_pret &&
                   heure == pret.heure &&
                   date_remise == pret.date_remise &&
                   nom_utilisateur == pret.nom_utilisateur &&
                   etat == pret.etat;
        }

        public override int GetHashCode()
        {
            int hashCode = -2037683541;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(idClient);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(date_pret);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(heure);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(date_remise);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nom_utilisateur);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(etat);
            return hashCode;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


    }
}
