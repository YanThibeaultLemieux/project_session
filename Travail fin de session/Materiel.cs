using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

        public Materiel(string id, string marque, string modèle, string état, string note)
        {
            this.id = id;
            this.marque = marque;
            this.modèle = modèle;
            this.état = état;
            this.note = note;
        }

        public Materiel()
        {
            this.id = "";
            this.marque = "";
            this.modèle = "";
            this.état = "";
            this.note = "";
        }

        public string Id { get => id; set => id = value; }
        public string Marque { get => marque;
            set { marque = value;
                this.OnPropertyChanged();  } }
        public string Modèle { get => modèle; 
            set {  modèle = value;
                this.OnPropertyChanged();
            } }
        public string État { get => état; 
            set {  état = value;
                this.OnPropertyChanged();
            } }
        public string Note { get => note; 
            set {  note = value;
                this.OnPropertyChanged();
            } }

        public override bool Equals(object obj)
        {
            return obj is Materiel materiel &&
                   id == materiel.id &&
                   marque == materiel.marque &&
                   modèle == materiel.modèle &&
                   état == materiel.état &&
                   note == materiel.note;
        }

        public override int GetHashCode()
        {
            int hashCode = -1002512410;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(id);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(marque);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(modèle);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(état);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(image);
            return hashCode;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }
}
