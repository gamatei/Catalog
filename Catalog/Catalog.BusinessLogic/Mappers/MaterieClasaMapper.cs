using Catalog.Entities;
using Catalog.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.BusinessLogic.Mappers
{
    public static class MaterieClasaMapper
    {
        public static MaterieClasa ToEntity(this MaterieClasaModel materieClasaModel)
        {

            return new MaterieClasa()
            {
                ID = materieClasaModel.ID,
                IDClasa= materieClasaModel.IDClasa,
                OreSaptamanal= materieClasaModel.OreSaptamanal,
                IDProfesor= materieClasaModel.IDProfesor
            };
        }

        public static MaterieClasaModel ToModel(this MaterieClasa materieClasa)
        {
            return new MaterieClasaModel()
            {
                ID = materieClasa.ID,
                IDClasa = materieClasa.IDClasa,
                OreSaptamanal = materieClasa.OreSaptamanal,
                IDProfesor = materieClasa.IDProfesor
            };
        }
    }
}
