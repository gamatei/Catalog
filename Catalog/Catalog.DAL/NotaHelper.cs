using Catalog.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Catalog.DAL
{
    public class NotaHelper
    {
        public static IEnumerable<Nota> GetAll()
        {
            IEnumerable<Nota> retValue;
            using (var context = new CatalogProjectEntities())
            {
                retValue = context.Notas.ToList();
            }
            return retValue;
        }

        public static Nota Get(int id)
        {
            Nota retValue;
            using (var context = new CatalogProjectEntities())
            {
                retValue = context.Notas.FirstOrDefault(x => x.ID == id);
            }
            return retValue;
        }

        public static Nota Insert(Nota entity)
        {
            using (var context = new CatalogProjectEntities())
            {
                entity = context.Notas.Add(entity);
                context.SaveChanges();
            }
            return entity;
        }

        public static void Delete(int id)
        {
            using (var context = new CatalogProjectEntities())
            {
                var entity = context.Notas.FirstOrDefault(x => x.ID == id);
                if (entity != null)
                {
                    context.Notas.Remove(entity);
                    context.SaveChanges();
                }
            }
        }

        public static void Update(Nota nota)
        {
            using (var context = new CatalogProjectEntities())
            {
                var dbEntity = context.Notas.FirstOrDefault(x => x.ID == nota.ID);
                if (dbEntity == null)
                {
                    dbEntity = new Nota();
                    context.Notas.Add(dbEntity);
                }
                dbEntity.IDElev = nota.IDElev;
                dbEntity.IDMaterieClasa = nota.IDMaterieClasa;
                dbEntity.Nota1 = nota.Nota1;
                dbEntity.DataNota = nota.DataNota;

                context.SaveChanges();
            }
        }
    }
}
