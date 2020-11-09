using Catalog.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Catalog.DAL
{
    public class UtilizatorHelper
    {
        public static IEnumerable<Utilizator> GetAll()
        {
            IEnumerable<Utilizator> retValue;
            using (var context = new CatalogProjectEntities())
            {
                retValue = context.Utilizators.ToList();
            }
            return retValue;
        }

        public static Utilizator Get(int id)
        {
            Utilizator retValue;
            using (var context = new CatalogProjectEntities())
            {
                retValue = context.Utilizators.FirstOrDefault(x => x.ID == id);
            }
            return retValue;
        }

        public static Utilizator Insert(Utilizator entity)
        {
            using (var context = new CatalogProjectEntities())
            {
                entity = context.Utilizators.Add(entity);
                context.SaveChanges();
            }
            return entity;
        }

        public static void Delete(int id)
        {
            using (var context = new CatalogProjectEntities())
            {
                var entity = context.Utilizators.FirstOrDefault(x => x.ID == id);
                if (entity != null)
                {
                    context.Utilizators.Remove(entity);
                    context.SaveChanges();
                }
            }
        }

        public static void Update(Utilizator utilizator)
        {
            using (var context = new CatalogProjectEntities())
            {
                var dbEntity = context.Utilizators.FirstOrDefault(x => x.ID == utilizator.ID);
                if (dbEntity == null)
                {
                    dbEntity = new Utilizator();
                    context.Utilizators.Add(dbEntity);
                }
                dbEntity.Username = utilizator.Username;
                dbEntity.Parola = utilizator.Parola;
                dbEntity.IDFunctie = utilizator.IDFunctie;
                dbEntity.Email = utilizator.Email;
                dbEntity.Prenume = utilizator.Prenume;
                dbEntity.Nume = utilizator.Nume;
                dbEntity.ContActiv = utilizator.ContActiv;
                dbEntity.IDElev = utilizator.IDElev;

                context.SaveChanges();
            }
        }
    }
}
 