using Catalog.DAL;
using Catalog.Entities;
using Catalog.Model;
using System.Collections.Generic;
using Catalog.BusinessLogic.Mappers;

namespace Catalog.BusinessLogic
{
    public class ElevBusiness
    {      

        public IEnumerable<ElevModel> GetElevi()
        {
            var retValue = new List<ElevModel>();
            var entities = ElevHelper.GetAll();

            foreach (var elev in entities)
            {
                retValue.Add(elev.ToModel());
            }
            return retValue;
        }

        public ElevModel Get(int id)
        {
            return ElevHelper.Get(id).ToModel();
        }

        public void Insert(ElevModel elevModel)
        {
            var elev = elevModel.ToEntity();
            ElevHelper.Insert(elev);

        }

        public void Delete(int id)
        {
            ElevHelper.Delete(id);
        }

        public void Update(ElevModel elevModel)
        {
            ElevHelper.Update(elevModel.ToEntity());
        }
    }
}
