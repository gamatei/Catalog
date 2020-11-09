using Catalog.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Catalog.DAL
{
    public class ClasaHelper
    {
        public static IEnumerable<Clasa> GetAll()
        {
            IEnumerable<Clasa> retValue;
            using (var context = new CatalogProjectEntities())
            {
                retValue = context.Clasas;
            }
            return retValue;
        }

        public static Clasa Get(int id)
        {
            Clasa retValue;
            using (var context = new CatalogProjectEntities())
            {
                retValue = context.Clasas.FirstOrDefault(x => x.ID == id);
            }
            return retValue;
        }

        public static Clasa Insert(Clasa entity)
        {
            using (var context = new CatalogProjectEntities())
            {
                entity = context.Clasas.Add(entity);
                context.SaveChanges();
            }
            return entity;
        }

        public static void Delete(int id)
        {
            using (var context = new CatalogProjectEntities())
            {
                var entity = context.Clasas.FirstOrDefault(x => x.ID == id);
                if (entity != null)
                {
                    context.Clasas.Remove(entity);
                    context.SaveChanges();
                }
            }
        }

        public static void Update(Clasa clasa)
        {
            using (var context = new CatalogProjectEntities())
            {
                var dbEntity = context.Clasas.FirstOrDefault(x => x.ID == clasa.ID);
                if (dbEntity == null)
                {
                    dbEntity = new Clasa();
                    context.Clasas.Add(dbEntity);
                }
                dbEntity.Nume = clasa.Nume;
                dbEntity.IDDiriginte = clasa.IDDiriginte;

                context.SaveChanges();
            }
        }
    }
}
