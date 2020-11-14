using Catalog.Entities;
using Catalog.Model;

namespace Catalog.BusinessLogic.Mappers
{
    public static class ElevMapper
    {
        public static Elev ToEntity(this ElevModel elevModel)
        {

            return new Elev()
            {
                IDUtilizator=elevModel.IDUtilizator,
                IDClasa=elevModel.IDClasa
            };
        }

        public static ElevModel ToModel(this Elev elev)
        {
            return new ElevModel()
            {
                IDUtilizator = elev.IDUtilizator,
                IDClasa = elev.IDClasa
            };
        }
    }
}
