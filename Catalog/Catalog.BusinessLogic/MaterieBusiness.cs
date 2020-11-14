using Catalog.BusinessLogic.Mappers;
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
                retValue.Add(materie.ToModel());
            }

            return retValue;
        }

        public void Insert(MaterieModel materieModel)
        {
            var materie = materieModel.ToEntity();            
            MaterieHelper.Insert(materie);

        }

        public void Delete(int id)
        {
            MaterieHelper.Delete(id);
        }

        public void Update(MaterieModel materieModel)
        {
            MaterieHelper.Update(materieModel.ToEntity());
        }

    }
}
