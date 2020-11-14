using Catalog.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Catalog.DAL
{
    public class MaterieClasaHelper
    {
        public static IEnumerable<MaterieClasa> GetAll()
        {
            IEnumerable<MaterieClasa> retValue;
            using (var context = new CatalogProjectEntities())
            {
                retValue = context.MaterieClasas.ToList();
            }
            return retValue;
        }

        public static MaterieClasa Get(int id)
        {
            MaterieClasa retValue;
            using (var context = new CatalogProjectEntities())
            {
                retValue = context.MaterieClasas.FirstOrDefault(x => x.ID == id);
            }
            return retValue;
        }

        public static MaterieClasa Insert(MaterieClasa entity)
        {
            using (var context = new CatalogProjectEntities())
            {
                entity = context.MaterieClasas.Add(entity);
                context.SaveChanges();
            }
            return entity;
        }

        public static void Delete(int id)
        {
            using (var context = new CatalogProjectEntities())
            {
                var entity = context.MaterieClasas.FirstOrDefault(x => x.ID == id);
                if (entity != null)
                {
                    context.MaterieClasas.Remove(entity);
                    context.SaveChanges();
                }
            }
        }

        public static void Update(MaterieClasa materieClasa)
        {
            using (var context = new CatalogProjectEntities())
            {
                var dbEntity = context.MaterieClasas.FirstOrDefault(x => x.ID == materieClasa.ID);
                if (dbEntity == null)
                {
                    dbEntity = new MaterieClasa();
                    context.MaterieClasas.Add(dbEntity);
                }
                dbEntity.IDClasa = materieClasa.IDClasa;
                dbEntity.IDMaterie = materieClasa.IDMaterie;
                dbEntity.OreSaptamanal = materieClasa.OreSaptamanal;
                dbEntity.IDProfesor = materieClasa.IDProfesor;

                context.SaveChanges();
            }
        }
    }
}
