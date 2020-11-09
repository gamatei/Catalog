using Catalog.DAL;
using Catalog.Entities;
using Catalog.Model;
using System.Collections.Generic;

namespace Catalog.BusinessLogic
{
    public class MaterieClasaBusiness
    {
        public IEnumerable<MaterieClasaModel> GetUsers()
        {
            var retValue = new List<MaterieClasaModel>();
            var entities = MaterieClasaHelper.GetAll();

            foreach (var materieClasa in entities)
            {
                retValue.Add(new MaterieClasaModel
                {
                    ID = materieClasa.ID,
                    IDClasa = materieClasa.IDClasa,
                    IDMaterie = materieClasa.IDMaterie,
                    OreSaptamanal = (int)materieClasa.OreSaptamanal,
                    IDProfesor = (int)materieClasa.IDProfesor
                });
            }

            return retValue;
        }
    }
}
