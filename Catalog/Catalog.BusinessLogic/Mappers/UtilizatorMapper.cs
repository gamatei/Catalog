﻿using Catalog.DAL;
using Catalog.Entities;
using Catalog.Model;

namespace Catalog.BusinessLogic.Mappers
{
    public static class UtilizatorMapper
    {
        public static Utilizator ToEntity(this UtilizatorModel utilizatorModel) 
        {           

            return new Utilizator()
            {
                ID = utilizatorModel.ID,
                Username = utilizatorModel.Username,                
                IDFunctie = utilizatorModel.IDFunctie,
                Email = utilizatorModel.Email,
                Prenume = utilizatorModel.Prenume,
                Nume = utilizatorModel.Nume,
                IDElev = utilizatorModel.IDElev
            };
        }

        public static UtilizatorModel ToModel(this Utilizator utilizator)
        {
            var functie = FunctieHelper.Get(utilizator.IDFunctie);

            return new UtilizatorModel()
            {
                ID = utilizator.ID,
                Username = utilizator.Username,
                IDFunctie = utilizator.IDFunctie,
                Email = utilizator.Email,
                Functie = functie.Descriere,
                Prenume = utilizator.Prenume,
                Nume = utilizator.Nume,
                IDElev = utilizator.IDElev
            };
        }

        
    }
}
