using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail_fin_de_session
{
    class Utilisateurs
    {
        String nom_utilisateur;
        String nom;
        String prenom;
        String motdepasse;

        public Utilisateurs(string nom_utilisateur, string nom, string prenom, string motdepasse)
        {
            this.nom_utilisateur = nom_utilisateur;
            this.nom = nom;
            this.prenom = prenom;
            this.motdepasse = motdepasse;
        }

        public Utilisateurs()
        {
            this.nom_utilisateur = "";
            this.nom = "";
            this.prenom = "";
            this.motdepasse = "";
        }

        public string Nom_utilisateur { get => nom_utilisateur; set => nom_utilisateur = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Motdepasse { get => motdepasse; set => motdepasse = value; }

        public override bool Equals(object obj)
        {
            return obj is Utilisateurs utilisateurs &&
                   nom_utilisateur == utilisateurs.nom_utilisateur &&
                   nom == utilisateurs.nom &&
                   prenom == utilisateurs.prenom &&
                   motdepasse == utilisateurs.motdepasse;
        }

        public override int GetHashCode()
        {
            int hashCode = 1981333798;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nom_utilisateur);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nom);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(prenom);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(motdepasse);
            return hashCode;
        }

        public override String ToString()
        {
            return $"Nom d'utilisateur: {Nom_utilisateur} " +
                $" - Nom: {Nom}  -  Prenom: {Prenom} -  Motdepasse: {Motdepasse}";
        }

    }
}
