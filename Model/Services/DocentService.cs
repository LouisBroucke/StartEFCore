using Model.Entities;
using Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Services
{
    public class DocentService
    {
        readonly private EFOpleidingenContext context;

        public DocentService(EFOpleidingenContext context)
        {
            this.context = context;
        }

        public IEnumerable<Docent> GetDocentenVoorCampus(int campus)
        {
            //throw new NotImplementedException();
            return context.Docenten.Where(x => x.CampusId == campus).ToList();
        }

        public Docent GetDocent(int id)
        {
            //throw new NotImplementedException();
            if (id == 0)
            {
                throw new ArgumentException(nameof(id));
            }

            return context.Docenten.FirstOrDefault(x => x.DocentId == id);
        }

        public void ToevoegenDocent(Docent docent)
        {
            //throw new NotImplementedException();

            if(String.IsNullOrEmpty(docent.LandCode))
            {
                docent.LandCode = "BE";
            }

            context.Docenten.Add(docent);
        }
    }
}
