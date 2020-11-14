using Catalog.Entities;
using Catalog.Model;

namespace Catalog.BusinessLogic.Mappers
{
    public static class ClasaMapper
    {
        public static Clasa ToEntity(this ClasaModel clasaModel)
        {

            return new Clasa()
            {
                ID = clasaModel.ID,
                Nume = clasaModel.Nume,
                IDDiriginte = clasaModel.IDDiriginte,
            };
        }

        public static ClasaModel ToModel(this Clasa clasa)
        {
            return new ClasaModel()
            {
                ID = clasa.ID,
                Nume = clasa.Nume,
                IDDiriginte = clasa.IDDiriginte,
            };
        }
    }
}
