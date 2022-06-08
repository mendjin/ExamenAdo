using ExamenAdo.BO;
using HelloPam.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExamenAdo.DAL
{
    public class ParticipantDAO
    {
        private readonly Sql sql;

        public ParticipantDAO()
        {
            sql = new Sql("ExamenAdo");
        }


        public void Add(Participants participants)
        {
            sql.Execute
                (
                "Sp_Participants_Insert",
                GetParameters(participants),
                true
                );
        }

        private IEnumerable<Sql.Parameter> GetParameters(Participants participants)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            sql.Execute
                (
                    "Sp_Participants_Delete",
                    GetParameters(new Participants { Id = id }),
                    true
                );
        }




        public Participants Get(int id)
        {
            var reader = sql.Read
                (
                    "Sp_Participants_Select",
                    GetParameters(new Participants { Id = id }),
                    true
                );
            while (reader.Read())
                return GetObject(reader);
            return null;
        }

        private Participants GetObject(System.Data.Common.DbDataReader reader)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Participants> Find(Participants participant = null)
        {
            var reader = sql.Read
                (
                    "Sp_Participants_Select",
                    GetParameters(participant),
                    true
                );
            var produits = new List<Participants>();
            while (reader.Read())
                produits.Add(GetObject(reader));
            return produits;
        }

    }
}
