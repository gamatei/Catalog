using Catalog.BusinessLogic.Mappers;
using Catalog.DAL;
using Catalog.Model;
using System.Collections.Generic;

namespace Catalog.BusinessLogic
{
    public class AbsentaBusiness
    {
        public IEnumerable<AbsentaModel> GetAbsente()
        {
            var retValue = new List<AbsentaModel>();
            var entities = AbsentaHelper.GetAll();

            foreach (var absenta in entities)
            {
                retValue.Add(absenta.ToModel());

            }
            return retValue;
        }

        public AbsentaModel Get(int id)
        {
            return AbsentaHelper.Get(id).ToModel();
        }

        public void Insert(AbsentaModel absentaModel)
        {
            var absenta = absentaModel.ToEntity();
            AbsentaHelper.Insert(absenta);

        }

        public void Delete(int id)
        {
            AbsentaHelper.Delete(id);
        }

        public void Update(AbsentaModel absentaModel)
        {
            AbsentaHelper.Update(absentaModel.ToEntity());
        }
    }
}
