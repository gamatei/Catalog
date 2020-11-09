using Catalog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.DAL
{
    public class UtilizatorAsteptareHelper
    {
        public static IEnumerable<UtilizatorAsteptare> GetAll()
        {
            IEnumerable<UtilizatorAsteptare> retValue;
            using (var context = new CatalogProjectEntities())
            {
                retValue = context.UtilizatorAsteptares;
            }
            return retValue;
        }

        public static UtilizatorAsteptare Get(int id)
        {
            UtilizatorAsteptare retValue;
            using (var context = new CatalogProjectEntities())
            {
                retValue = context.UtilizatorAsteptares.FirstOrDefault(x => x.ID == id);
            }
            return retValue;
        }

        public static UtilizatorAsteptare Insert(UtilizatorAsteptare entity)
        {
            using (var context = new CatalogProjectEntities())
            {
                entity = context.UtilizatorAsteptares.Add(entity);
                context.SaveChanges();
            }
            return entity;
        }

        public static void Delete(int id)
        {
            using (var context = new CatalogProjectEntities())
            {
                var entity = context.UtilizatorAsteptares.FirstOrDefault(x => x.ID == id);
                if (entity != null)
                {
                    context.UtilizatorAsteptares.Remove(entity);
                    context.SaveChanges();
                }
            }
        }

        public static void Update(UtilizatorAsteptare utilizatorAsteptare)
        {
            using (var context = new CatalogProjectEntities())
            {
                var dbEntity = context.UtilizatorAsteptares.FirstOrDefault(x => x.ID == utilizatorAsteptare.ID);
                if (dbEntity == null)
                {
                    dbEntity = new UtilizatorAsteptare();
                    context.UtilizatorAsteptares.Add(dbEntity);
                }
                dbEntity.IDUtilizator = utilizatorAsteptare.IDUtilizator;
                dbEntity.Hash = utilizatorAsteptare.Hash;

                context.SaveChanges();
            }
        }
    }
}
