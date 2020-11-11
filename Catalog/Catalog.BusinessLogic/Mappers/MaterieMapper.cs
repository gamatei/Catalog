using Catalog.Entities;
using Catalog.Model;

namespace Catalog.BusinessLogic.Mappers
{
    public static class MaterieMapper
    {
        public static Materie ToEntity(this MaterieModel materieModel)
        {

            return new Materie()
            {
                ID = materieModel.ID,
                Nume = materieModel.Nume            
            };
        }

        public static MaterieModel ToModel(this Materie materie)
        {     
            return new MaterieModel()
            {
                ID = materie.ID,
                Nume = materie.Nume
            };
        }
    }
}
