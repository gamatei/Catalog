using Catalog.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Catalog.DAL
{
    public class ProfesorHelper
    {
        public static IEnumerable<Profesor> GetAll()
        {
            IEnumerable<Profesor> retValue;
            using (var context = new CatalogProjectEntities())
            {
                retValue = context.Profesors.ToList();
            }
            return retValue;
        }

        public static Profesor Get(int id)
        {
            Profesor retValue;
            using (var context = new CatalogProjectEntities())
            {
                retValue = context.Profesors.FirstOrDefault(x => x.ID == id);
            }
            return retValue;
        }

        public static Profesor Insert(Profesor entity)
        {
            using (var context = new CatalogProjectEntities())
            {
                entity = context.Profesors.Add(entity);
                context.SaveChanges();
            }
            return entity;
        }

        public static void Delete(int id)
        {
            using (var context = new CatalogProjectEntities())
            {
                var entity = context.Profesors.FirstOrDefault(x => x.ID == id);
                if (entity != null)
                {
                    context.Profesors.Remove(entity);
                    context.SaveChanges();
                }
            }
        }

        public static void Update(Profesor profesor)
        {
            using (var context = new CatalogProjectEntities())
            {
                var dbEntity = context.Profesors.FirstOrDefault(x => x.ID == profesor.ID);
                if (dbEntity == null)
                {
                    dbEntity = new Profesor();
                    context.Profesors.Add(dbEntity);
                }
                dbEntity.IDUtilizator = profesor.IDUtilizator;
                dbEntity.Detalii = profesor.Detalii;
                dbEntity.IDMaterie = profesor.IDMaterie;

                context.SaveChanges();
            }
        }
    }
}
