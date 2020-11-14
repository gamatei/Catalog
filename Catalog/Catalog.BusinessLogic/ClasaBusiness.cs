using Catalog.DAL;
using Catalog.Entities;
using Catalog.Model;
using System.Collections.Generic;
using Catalog.BusinessLogic.Mappers;

namespace Catalog.BusinessLogic
{
    public class ClasaBusiness
    {
        public IEnumerable<ClasaModel> GetClase()
        {
            var retValue = new List<ClasaModel>();
            var entities = ClasaHelper.GetAll();

            foreach (var clasa in entities)
            {
                retValue.Add(clasa.ToModel());

            }
            return retValue;
        }

        public ClasaModel Get(int id)
        {
            return ClasaHelper.Get(id).ToModel();
        }

        public void Insert(ClasaModel clasaModel)
        {
            var clasa = clasaModel.ToEntity();
            ClasaHelper.Insert(clasa);

        }

        public void Delete(int id)
        {
            ClasaHelper.Delete(id);
        }

        public void Update(ClasaModel clasaModel)
        {
            ClasaHelper.Update(clasaModel.ToEntity());
        }

    }
}
