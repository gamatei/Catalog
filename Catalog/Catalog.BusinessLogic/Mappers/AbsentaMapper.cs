using Catalog.Entities;
using Catalog.Model;

namespace Catalog.BusinessLogic.Mappers
{
    public static class AbsentaMapper
    {
        public static Absenta ToEntity(this AbsentaModel absentaModel)
        {

            return new Absenta()
            {
               IDElev=absentaModel.IDElev,
               IDMaterieClasa=absentaModel.IDMaterieClasa,
               DataAbsenta=absentaModel.DataAbsenta
            };
        }

        public static AbsentaModel ToModel(this Absenta absenta)
        {
            return new AbsentaModel()
            {
                IDElev = absenta.IDElev,
                IDMaterieClasa = absenta.IDMaterieClasa,
                DataAbsenta = absenta.DataAbsenta
            };
        }
    }
}
