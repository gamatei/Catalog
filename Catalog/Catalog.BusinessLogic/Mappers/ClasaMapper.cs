using Catalog.Entities;
using Catalog.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.BusinessLogic.Mappers
{
    public static class ClasaMapper
    {
        public static Clasa ToEntity(this ClasaModel clasaModel)
        {

            return new Clasa()
            {
                ID = clasaModel.ID,
                Nume = clasaModel.Nume,
                IDDiriginte = clasaModel.IDDiriginte,
            };
        }

        public static ClasaModel ToModel(this Clasa clasa)
        {
            return new ClasaModel()
            {
                ID = clasa.ID,
                Nume = clasa.Nume,
                IDDiriginte = clasa.IDDiriginte,
            };
        }
    }
}
