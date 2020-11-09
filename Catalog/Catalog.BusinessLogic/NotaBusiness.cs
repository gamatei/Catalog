using Catalog.DAL;
using Catalog.Entities;
using Catalog.Model;
using System.Collections.Generic;

namespace Catalog.BusinessLogic
{
    public class NotaBusiness
    {
        public IEnumerable<NotaModel> GetUsers()
        {
            var retValue = new List<NotaModel>();
            var entities = NotaHelper.GetAll();

            foreach (var nota in entities)
            {
                retValue.Add(new NotaModel
                {
                    ID = nota.ID,
                    IDElev = nota.IDElev,
                    IDMaterieClasa = nota.IDMaterieClasa,
                    Nota = (int)nota.Nota1,
                    DataNota= nota.DataNota
                });
            }

            return retValue;
        }
    }
}
