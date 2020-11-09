using Catalog.DAL;
using Catalog.Entities;
using Catalog.Model;
using System.Collections.Generic;

namespace Catalog.BusinessLogic
{
    public class ProfesorBusiness
    {
        public IEnumerable<ProfesorModel> GetUsers()
        {
            var retValue = new List<ProfesorModel>();
            var entities = ProfesorHelper.GetAll();

            foreach (var profesor in entities)
            {
                retValue.Add(new ProfesorModel
                {
                    ID = profesor.ID,
                    IDUtilizator = profesor.IDUtilizator,
                    Detalii=profesor.Detalii,
                    IDMaterie=profesor.IDMaterie
                });
            }

            return retValue;
        }
    }
}
