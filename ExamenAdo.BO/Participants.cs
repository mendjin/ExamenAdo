using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenAdo.BO
{
    public class Participants
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Sexe { get; set; }
        public int Age { get; set; }
        public string Ville { get; set; }
        public DateTime? DateInscription { get; set; }
        public byte[] Photos { get; set; }

        public Participants()
        {
        }

        public Participants(int id, string nom, string sexe, int age, string ville, DateTime? dateInscription, byte[] photos)
        {
            Id = id;
            Nom = nom;
            Sexe = sexe;
            Age = age;
            Ville = ville;
            DateInscription = dateInscription;
            Photos = photos;
        }

        public override bool Equals(object obj)
        {
            return obj is Participants participants &&
                   Id == participants.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }
    }
}
