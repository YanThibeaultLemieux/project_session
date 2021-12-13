using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail_fin_de_session
{
    class Materiel
    {

        String id;
        String marque;
        String modèle;
        String état;
        String note;
        String image;

        public Materiel(string id, string marque, string modèle, string état, string note, string image)
        {
            this.id = id;
            this.marque = marque;
            this.modèle = modèle;
            this.état = état;
            this.note = note;
            this.image = image;
        }

        public Materiel()
        {
            this.id = "";
            this.marque = "";
            this.modèle = "";
            this.état = "";
            this.note = "";
            this.image = "";
        }

        public string Id { get => id; set => id = value; }
        public string Marque { get => marque; set => marque = value; }
        public string Modèle { get => modèle; set => modèle = value; }
        public string État { get => état; set => état = value; }
        public string Note { get => note; set => note = value; }
        public string Image { get => image; set => image = value; }

        public override bool Equals(object obj)
        {
            return obj is Materiel materiel &&
                   id == materiel.id &&
                   marque == materiel.marque &&
                   modèle == materiel.modèle &&
                   état == materiel.état &&
                   note == materiel.note &&
                   image == materiel.image;
        }

        public override int GetHashCode()
        {
            int hashCode = -1002512410;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(id);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(marque);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(modèle);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(état);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(note);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(image);
            return hashCode;
        }
    }
}
