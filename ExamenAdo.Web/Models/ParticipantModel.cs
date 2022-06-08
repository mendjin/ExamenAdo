using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenAdo.Web.Models
{
    public class ParticipantModel
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Sexe { get; set; }
        public int Age { get; set; }
        public DateTime? DateInscription { get; set; }
        public byte[] Photos { get; set; }

        public HttpPostedFileBase Image { get; set; }

        public ParticipantModel()
        {
        }

        public ParticipantModel(int id, string nom, string sexe, int age, DateTime? dateInscription, byte[] photos, HttpPostedFileBase image)
        {
            Id = id;
            Nom = nom;
            Sexe = sexe;
            Age = age;
            DateInscription = dateInscription;
            Photos = photos;
            Image = image;
        }
    }
}