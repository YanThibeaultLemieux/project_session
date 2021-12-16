using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail_fin_de_session
{
    class detailPret
    {
        int idPret;
        string idMat;
        string estRetourné;
        string utilisateur;

        public detailPret(int idPret, string idMat, int estRetourné, string utilisateur)
        {
            this.idPret = idPret;
            this.idMat = idMat;
            EstRetourné1 = estRetourné;
            this.utilisateur = utilisateur;
        }

        public int IdPret { get => idPret; set => idPret = value; }
        public string IdMat { get => idMat; set => idMat = value; }
        public string EstRetourné { get => estRetourné; set => estRetourné = value; }
        public string Utilisateur { get => utilisateur; set => utilisateur = value; }
        public int EstRetourné1 { get; }

        public override bool Equals(object obj)
        {
            return obj is detailPret pret &&
                   idPret == pret.idPret &&
                   idMat == pret.idMat &&
                   estRetourné == pret.estRetourné &&
                   utilisateur == pret.utilisateur;
        }

        public override int GetHashCode()
        {
            int hashCode = -827547918;
            hashCode = hashCode * -1521134295 + idPret.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(idMat);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(estRetourné);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(utilisateur);
            return hashCode;
        }

        public override String ToString()
        {
            return $"Identification:"
                + " - Matériel: {IdMat}  -  Retourné? : {EstRetourné} -  Utilisateur: {utilisateur}";
        }
    }
}
