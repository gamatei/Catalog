using Catalog.Entities;
using Catalog.Model;

namespace Catalog.BusinessLogic.Mappers
{
    public static class ProfesorMapper
    {
        public static Profesor ToEntity(this ProfesorModel profesorModel)
        {

            return new Profesor()
            {
                IDUtilizator=profesorModel.IDUtilizator,
                Detalii=profesorModel.Detalii,
                IDMaterie=profesorModel.IDMaterie
            };
        }

        public static ProfesorModel ToModel(this Profesor profesor)
        {
            return new ProfesorModel()
            {
                IDUtilizator = profesor.IDUtilizator,
                Detalii = profesor.Detalii,
                IDMaterie = profesor.IDMaterie
            };
        }
    }
}
