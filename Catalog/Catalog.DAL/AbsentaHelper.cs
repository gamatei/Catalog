using Catalog.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Catalog.DAL
{
    public class AbsentaHelper
    {
        public static IEnumerable<Absenta> GetAll()
        {
            IEnumerable<Absenta> retValue;
            using (var context = new CatalogProjectEntities())
            {
                retValue = context.Absentas;
            }
            return retValue;
        }

        public static Absenta Get(int id)
        {
            Absenta retValue;
            using (var context = new CatalogProjectEntities())
            {
                retValue = context.Absentas.FirstOrDefault(x => x.ID == id);
            }
            return retValue;
        }

        public static Absenta Insert(Absenta entity)
        {
            using (var context = new CatalogProjectEntities())
            {
                entity = context.Absentas.Add(entity);
                context.SaveChanges();
            }
            return entity;
        }

        public static void Delete(int id)
        {
            using (var context = new CatalogProjectEntities())
            {
                var entity = context.Absentas.FirstOrDefault(x => x.ID == id);
                if (entity != null)
                {
                    context.Absentas.Remove(entity);
                    context.SaveChanges();
                }
            }
        }

        public static void Update(Absenta absenta)
        {
            using (var context = new CatalogProjectEntities())
            {
                var dbEntity = context.Absentas.FirstOrDefault(x => x.ID == absenta.ID);
                if (dbEntity == null)
                {
                    dbEntity = new Absenta();
                    context.Absentas.Add(dbEntity);
                }
                dbEntity.IDElev = absenta.IDElev;
                dbEntity.IDMaterieClasa = absenta.IDMaterieClasa;
                dbEntity.DataAbsenta = absenta.DataAbsenta;

                context.SaveChanges();
            }
        }
    }
}
