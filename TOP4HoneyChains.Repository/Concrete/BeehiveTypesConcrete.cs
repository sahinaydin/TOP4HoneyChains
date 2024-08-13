using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TOP4HoneyChains.Entities;
using TOP4HoneyChains.Repository.Abstract;

namespace TOP4HoneyChains.Repository.Concrete
{
    public class BeehiveTypesConcrete : IDatabaseBusiness<BeehiveType>
    {
        public void Delete(BeehiveType entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.BeehiveTypes.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                var entity = db.BeehiveTypes.Find(id);
                db.BeehiveTypes.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public BeehiveType Get(Expression<Func<BeehiveType, bool>> expression)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.BeehiveTypes.Where(expression).FirstOrDefault();
            }
        }

        public List<BeehiveType> GetAll()
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.BeehiveTypes.ToList();
            }
        }

        public List<BeehiveType> GetAll(Expression<Func<BeehiveType, bool>> expression)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.BeehiveTypes.Where(expression).ToList();
            }
        }

        public BeehiveType GetById(int id)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.BeehiveTypes.Find(id);
            }
        }

        public void Insert(BeehiveType entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.BeehiveTypes.Attach(entity);
                db.Entry(entity).State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Update(BeehiveType entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.BeehiveTypes.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
