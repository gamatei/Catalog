using Catalog.DAL;
using Catalog.Entities;
using Catalog.Model;
using System.Collections.Generic;

namespace Catalog.BusinessLogic
{
    public class ClasaBusiness
    {
        public IEnumerable<ClasaModel> GetUsers()
        {
            var retValue = new List<ClasaModel>();
            var entities = ClasaHelper.GetAll();

            foreach (var clasa in entities)
            {
                retValue.Add(new ClasaModel
                {
                    ID = clasa.ID,
                    Nume = clasa.Nume,
                    IDDiriginte = clasa.IDDiriginte
                });
            }
            return retValue;
        }
    }
}
