using Catalog.BusinessLogic.Mappers;
using Catalog.DAL;
using Catalog.Model;
using System.Collections.Generic;

namespace Catalog.BusinessLogic
{
    public class NotaBusiness
    {
        public IEnumerable<NotaModel> GetNotes()
        {
            var retValue = new List<NotaModel>();
            var entities = NotaHelper.GetAll();

            foreach (var nota in entities)
            {
                retValue.Add(nota.ToModel());

            }
            return retValue;
        }

        public NotaModel Get(int id)
        {
            return NotaHelper.Get(id).ToModel();
        }

        public void Insert(NotaModel notaModel)
        {
            var nota = notaModel.ToEntity();
            NotaHelper.Insert(nota);

        }

        public void Delete(int id)
        {
            NotaHelper.Delete(id);
        }

        public void Update(NotaModel notaModel)
        {
            NotaHelper.Update(notaModel.ToEntity());
        }
    }
}
