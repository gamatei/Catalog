using Catalog.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Catalog.DAL
{
    public class ElevHelper
    {
        public static IEnumerable<Elev> GetAll()
        {
            IEnumerable<Elev> retValue;
            using (var context = new CatalogProjectEntities())
            {
                retValue = context.Elevs.ToList();
            }
            return retValue;
        }

        public static Elev Get(int id)
        {
            Elev retValue;
            using (var context = new CatalogProjectEntities())
            {
                retValue = context.Elevs.FirstOrDefault(x => x.ID == id);
            }
            return retValue;
        }

        public static Elev Insert(Elev entity)
        {
            using (var context = new CatalogProjectEntities())
            {
                entity = context.Elevs.Add(entity);
                context.SaveChanges();
            }
            return entity;
        }

        public static void Delete(int id)
        {
            using (var context = new CatalogProjectEntities())
            {
                var entity = context.Elevs.FirstOrDefault(x => x.ID == id);
                if (entity != null)
                {
                    context.Elevs.Remove(entity);
                    context.SaveChanges();
                }
            }
        }

        public static void Update(Elev elev)
        {
            using (var context = new CatalogProjectEntities())
            {
                var dbEntity = context.Elevs.FirstOrDefault(x => x.ID == elev.ID);
                if (dbEntity == null)
                {
                    dbEntity = new Elev();
                    context.Elevs.Add(dbEntity);
                }
                dbEntity.IDUtilizator = elev.IDUtilizator;
                dbEntity.IDClasa = elev.IDClasa;
                
                context.SaveChanges();
            }
        }
    }
}
