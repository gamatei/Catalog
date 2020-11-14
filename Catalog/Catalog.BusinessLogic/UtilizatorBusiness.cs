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
    public class UtilizatorBusiness
    {
        public UtilizatorModel ValidateUser(string username, string parola) {
            
            var user = UtilizatorHelper.GetByUsername(username);

            if (user == null) {
                return null;
            }

            var pswHash = Utilities.GetHash(parola);
            if (user.Parola != pswHash) {
                return null;
            }

            return user.ToModel();
        }

        public IEnumerable<UtilizatorModel> GetUsers()
        {
            var retValue = new List<UtilizatorModel>();
            var entities = UtilizatorHelper.GetAll();

            foreach (var utilizator in entities)
            {                
                retValue.Add(utilizator.ToModel());
               
            }
            return retValue;
        }

        public UtilizatorModel Get(int id)
        {
            return UtilizatorHelper.Get(id).ToModel();
        }

        public void Insert(UtilizatorModel utilizatorModel)
        {            
            var utilizator = utilizatorModel.ToEntity();
            utilizator.Parola = Utilities.GetHash("ParolaDefault");
            UtilizatorHelper.Insert(utilizator);
            
        }

        public void Delete(int id)
        {
            UtilizatorHelper.Delete(id);
        }

        public void Update(UtilizatorModel utilizatorModel)
        {
            UtilizatorHelper.Update(utilizatorModel.ToEntity());
        }


        //public void ChangePassword(ChangePSWModel model)
        // old password + new passwoprd + confirmation passowrd



        public static List<SelectListItem> GetFunctions(string role)
        {
            var functii = FunctieHelper.GetAll();
            switch (role) {
                case "Admin":
                    functii = functii.Where(x =>x.ID==1||x.ID==2|| x.ID == 3 || x.ID == 4);
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
