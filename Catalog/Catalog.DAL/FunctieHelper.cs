using Catalog.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Catalog.DAL
{
    public class FunctieHelper
    {
        public static IEnumerable<Functie> GetAll()
        {
            IEnumerable<Functie> retValue;
            using (var context = new CatalogProjectEntities())
            {
                retValue = context.Functies.ToList();
            }
            return retValue;
        }

        public static Functie Get(int id)
        {
            Functie retValue;
            using (var context = new CatalogProjectEntities())
            {
                retValue = context.Functies.FirstOrDefault(x => x.ID == id);
            }
            return retValue;
        }

        public static Functie Insert(Functie entity)
        {
            using (var context = new CatalogProjectEntities())
            {
                entity = context.Functies.Add(entity);
                context.SaveChanges();
            }
            return entity;
        }

        public static void Delete(int id)
        {
            using (var context = new CatalogProjectEntities())
            {
                var entity = context.Functies.FirstOrDefault(x => x.ID == id);
                if (entity != null)
                {
                    context.Functies.Remove(entity);
                    context.SaveChanges();
                }
            }
        }

        public static void Update(Functie functie)
        {
            using (var context = new CatalogProjectEntities())
            {
                var dbEntity = context.Functies.FirstOrDefault(x => x.ID == functie.ID);
                if (dbEntity == null)
                {
                    dbEntity = new Functie();
                    context.Functies.Add(dbEntity);
                }
                dbEntity.Descriere = functie.Descriere;

                context.SaveChanges();
            }
        }
    }
}
