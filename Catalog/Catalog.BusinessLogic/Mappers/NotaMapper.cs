using Catalog.Entities;
using Catalog.Model;

namespace Catalog.BusinessLogic.Mappers
{
    public static class NotaMapper
    {
        public static Nota ToEntity(this NotaModel notaModel)
        {

            return new Nota()
            {
                IDElev = notaModel.IDElev,
                IDMaterieClasa = notaModel.IDMaterieClasa,
                Nota1=notaModel.Nota,
                DataNota = notaModel.DataNota
            };
        }

        public static NotaModel ToModel(this Nota nota)
        {
            return new NotaModel()
            {
                IDElev = nota.IDElev,
                IDMaterieClasa = nota.IDMaterieClasa,
                Nota = nota.Nota1,
                DataNota = nota.DataNota
            };
        }
    }
}
