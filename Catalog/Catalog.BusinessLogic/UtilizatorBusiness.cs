using Catalog.BusinessLogic.Mappers;
using Catalog.BusinessLogic.Tools;
using Catalog.DAL;
using Catalog.Model;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Catalog.BusinessLogic
{
    public class UtilizatorBusiness
    {
        public IEnumerable<UtilizatorModel> GetUsers()
        {
            var retValue = new List<UtilizatorModel>();
            var entities = UtilizatorHelper.GetAll();

            foreach (var utilizator in entities)
            {
                // din entitate in model
                retValue.Add(utilizator.ToModel());
                //retValue.Add(new UtilizatorModel
                //{
                //    ID = utilizator.ID,
                //    Username = utilizator.Username,                    
                //    IDFunctie = utilizator.IDFunctie,
                //    Email = utilizator.Email,
                //    Prenume = utilizator.Prenume,
                //    Nume = utilizator.Nume,
                //    IDElev = utilizator.IDElev
                //});
            }
            return retValue;
        }

        public UtilizatorModel Get(int id)
        {
            return UtilizatorHelper.Get(id).ToModel();
        }

        public void Insert(UtilizatorModel utilizatorModel)
        {
            // utilizatorModel.Parola = "ParolaDefault";
            var utlizator = utilizatorModel.ToEntity();
            utlizator.Parola = Utilities.GetHash("ParolaDefault");
            UtilizatorHelper.Insert(utlizator);
            //UtilizatorHelper.Insert(new Utilizator()
            //{
            //    Username = utilizatorModel.Username,
            //    Parola = hash,
            //    IDFunctie = utilizatorModel.IDFunctie,
            //    Email = utilizatorModel.Email,
            //    Prenume = utilizatorModel.Prenume,
            //    Nume = utilizatorModel.Nume,
            //    IDElev = utilizatorModel.IDElev
            //});
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



        public static List<SelectListItem> GetFunctions()
        {
            var functii = FunctieHelper.GetAll();
            return functii.Select(x => new SelectListItem { Value = x.ID.ToString(), Text = x.Descriere }).ToList();
        }
    }
}
