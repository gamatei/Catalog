using Catalog.DAL;
using Catalog.Entities;
using Catalog.Model;
using System.Collections.Generic;

namespace Catalog.BusinessLogic
{
    public class MaterieBusiness
    {
        public IEnumerable<MaterieModel> GetMaterii()
        {
            var retValue = new List<MaterieModel>();
            var entities = MaterieHelper.GetAll();

            foreach (var materie in entities)
            {
                retValue.Add(new MaterieModel
                {
                    ID = materie.ID,
                    Nume=materie.Nume
                });
            }

            return retValue;
        }

    }
}
