using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Travail_fin_de_session
{
    class Client
    {
        String id;
        String nom;
        String prenom;
        String telephone;
        String poste;
        String bureau;
        String type;
        String email;


        public Client(string id, string nom, string prenom,  string telephone, string poste, string bureau, string type, string email)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.telephone = telephone;
            this.poste = poste;
            this.bureau = bureau;
            this.type = type;
            this.email = email;
        }
        public Client()
        {
            this.id = "";
            this.nom = "";
            this.prenom = "";
            this.telephone = "";
            this.poste = "";
            this.bureau = "";
            this.type = "";
            this.email = "";
        }
        public string Id { get => id;
            set {  id = value;
                this.OnPropertyChanged();
            }
        }
        public string Nom { get => nom;
            set {  nom = value;
                this.OnPropertyChanged();
            }
        }
        public string Prenom
        {
            get => prenom;
            set { prenom = value;
                this.OnPropertyChanged();
            }
        }
        public string Telephone { get => telephone; 
            set { telephone = value;
                this.OnPropertyChanged();
            } 
        }
        public string Poste { get => poste;
            set { poste = value;
                this.OnPropertyChanged();
            } 
        }
        public string Bureau { get => bureau; 
            set { bureau = value;
                this.OnPropertyChanged();
            }
        }
        public string Type { get => type; 
            set { type = value;
                this.OnPropertyChanged();
            } 
        }
        public string Email { get => email;
            set { email = value;
                this.OnPropertyChanged();
            }
        }

        public override bool Equals(object obj)
        {
            return obj is Client client &&
                   id == client.id &&
                   nom == client.nom &&
                   prenom == client.prenom &&
                   telephone == client.telephone &&
                   poste == client.poste &&
                   bureau == client.bureau &&
                   type == client.type &&
                   email == client.email;
        }

        public override int GetHashCode()
        {
            int hashCode = -118200851;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(id);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nom);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(prenom);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(telephone);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(poste);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(bureau);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(email);
            return hashCode;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public override String ToString()
        {
            return $"Identification: {Id} " +
                $" - Nom: {Nom}  -  Prenom: {Prenom} -  Téléphone: {Telephone} - Poste: {Poste} - Bureau: {Bureau} - Type: {Type} - email: {Email}";
        }

    }
}
