using Catalog.DAL;
using Catalog.Model;
using System.Collections.Generic;
using Catalog.BusinessLogic.Mappers;

namespace Catalog.BusinessLogic
{
    public class MaterieClasaBusiness
    {
        public IEnumerable<MaterieClasaModel> GetMaterieClase()
        {
            var retValue = new List<MaterieClasaModel>();
            var entities = MaterieClasaHelper.GetAll();

            foreach (var materieClasa in entities)
            {
                retValue.Add(materieClasa.ToModel());

            }
            return retValue;
        }

        public MaterieClasaModel Get(int id)
        {
            return MaterieClasaHelper.Get(id).ToModel();
        }

        public void Insert(MaterieClasaModel materieClasaModel)
        {
            var materieClasa = materieClasaModel.ToEntity();
            MaterieClasaHelper.Insert(materieClasa);

        }

        public void Delete(int id)
        {
            MaterieClasaHelper.Delete(id);
        }

        public void Update(MaterieClasaModel materieClasaModel)
        {
            MaterieClasaHelper.Update(materieClasaModel.ToEntity());
        }
    }
}
