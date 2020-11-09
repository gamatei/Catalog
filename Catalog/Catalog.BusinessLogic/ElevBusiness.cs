using Catalog.DAL;
using Catalog.Entities;
using Catalog.Model;
using System.Collections.Generic;

namespace Catalog.BusinessLogic
{
    public class ElevBusiness
    {
        public IEnumerable<ElevModel> GetUsers()
        {
            var retValue = new List<ElevModel>();
            var entities = ElevHelper.GetAll();

            foreach (var elev in entities)
            {
                retValue.Add(new ElevModel
                {
                    ID = elev.ID,
                    IDUtilizator = elev.IDUtilizator,
                    IDClasa=elev.IDClasa
                });
            }

            return retValue;
        }
    }
}
