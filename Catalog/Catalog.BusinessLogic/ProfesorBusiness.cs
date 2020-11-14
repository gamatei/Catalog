using Catalog.BusinessLogic.Mappers;
using Catalog.BusinessLogic.Tools;
using Catalog.DAL;
using Catalog.Entities;
using Catalog.Model;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Catalog.BusinessLogic
{
    public class ProfesorBusiness
    {
        public IEnumerable<ProfesorModel> GetProfessors()
        {
            var retValue = new List<ProfesorModel>();
            var entities = ProfesorHelper.GetAll();

            foreach (var profesor in entities)
            {
                retValue.Add(profesor.ToModel());

            }
            return retValue;
        }

        public ProfesorModel Get(int id)
        {
            return ProfesorHelper.Get(id).ToModel();
        }

        public void Insert(ProfesorModel profesorModel)
        {
            var profesor = profesorModel.ToEntity();
            ProfesorHelper.Insert(profesor);

        }

        public void Delete(int id)
        {
            ProfesorHelper.Delete(id);
        }

        public void Update(ProfesorModel profesorModel)
        {
            ProfesorHelper.Update(profesorModel.ToEntity());
        }

        public static List<SelectListItem> GetFunctions(string role)
        {
            var functii = FunctieHelper.GetAll();
            switch (role)
            {
                case "Admin": 
                    break;
                case "Profesor":
                    functii = functii.Where(x => x.ID == 3 || x.ID == 4);
                    break;
                case "Elev":
                    functii = functii.Where(x => x.ID == 3 || x.ID == 4);
                    break;
                default:
                    functii = new List<Functie>();
                    break;
            }
            return functii.Select(x => new SelectListItem { Value = x.ID.ToString(), Text = x.Descriere }).ToList();
        }


    }
}
