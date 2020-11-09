using Catalog.DAL;
using Catalog.Entities;
using Catalog.Model;
using System.Collections.Generic;

namespace Catalog.BusinessLogic
{
    public class FunctieBusiness
    {
        public IEnumerable<FunctieModel> GetUsers()
        {
            var retValue = new List<FunctieModel>();
            var entities = FunctieHelper.GetAll();

            foreach (var functie in entities)
            {
                retValue.Add(new FunctieModel
                {
                    ID = functie.ID,
                    Descriere = functie.Descriere
                });
            }

            return retValue;
        }
    }
}
