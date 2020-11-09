using Catalog.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Catalog.DAL
{
    public class MaterieHelper
    {
        public static IEnumerable<Materie> GetAll()
        {
            IEnumerable<Materie> retValue;
            using (var context = new CatalogProjectEntities())
            {
                retValue = context.Materies;
            }
            return retValue;
        }

        public static Materie Get(int id)
        {
            Materie retValue;
            using (var context = new CatalogProjectEntities())
            {
                retValue = context.Materies.FirstOrDefault(x => x.ID == id);
            }
            return retValue;
        }

        public static Materie Insert(Materie entity)
        {
            using (var context = new CatalogProjectEntities())
            {
                entity = context.Materies.Add(entity);
                context.SaveChanges();
            }
            return entity;
        }

        public static void Delete(int id)
        {
            using (var context = new CatalogProjectEntities())
            {
                var entity = context.Materies.FirstOrDefault(x => x.ID == id);
                if (entity != null)
                {
                    context.Materies.Remove(entity);
                    context.SaveChanges();
                }
            }
        }

        public static void Update(Materie materie)
        {
            using (var context = new CatalogProjectEntities())
            {
                var dbEntity = context.Materies.FirstOrDefault(x => x.ID == materie.ID);
                if (dbEntity == null)
                {
                    dbEntity = new Materie();
                    context.Materies.Add(dbEntity);
                }
                dbEntity.Nume = materie.Nume;

                context.SaveChanges();
            }
        }
    }
}
