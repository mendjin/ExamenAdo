using ExamenAdo.BO;
using ExamenAdo.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenAdo.BLL
{
    public class ParticipantManager
    {
        private readonly ParticipantDAO produitDAO;
        public ParticipantManager()
        {
            produitDAO = new ParticipantDAO();
        }


        public void CreateProduit(Participants participant)
        {
            if (participant == null)
                throw new ArgumentNullException("Le produit ne doit pas etre null! ");
            produitDAO.Add(participant);
        }


        public void DeleteProduit(int id)
        {
            produitDAO.Delete(id);
        }


        public Participants GetProduit(int id)
        {
            return produitDAO.Get(id);
        }

        public IEnumerable<Participants> FindProduit(Participants participant = null)
        {
            return produitDAO.Find(participant).ToList();
        }
    }
}
