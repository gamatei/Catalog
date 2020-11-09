using Catalog.DAL;
using Catalog.Entities;
using Catalog.Model;
using System.Collections.Generic;

namespace Catalog.BusinessLogic
{
    public class AbsentaBusiness
    {
        public IEnumerable<AbsentaModel> GetUsers()
        {
            var retValue = new List<AbsentaModel>();
            var entities = AbsentaHelper.GetAll();

            foreach (var absenta in entities)
            {
                retValue.Add(new AbsentaModel
                {
                    ID = absenta.ID,
                    IDElev = absenta.IDElev,
                    IDMaterieClasa = absenta.IDMaterieClasa,
                    DataAbsenta=absenta.DataAbsenta
                });
            }
            return retValue;
        }
    }
}
