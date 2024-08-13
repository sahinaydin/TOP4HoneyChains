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
    public class BeekeepingTypesConcrete : IDatabaseBusiness<BeekeepingType>
    {
        public void Delete(BeekeepingType entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.BeekeepingTypes.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                var entity = db.BeekeepingTypes.Find(id);
                db.BeekeepingTypes.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public BeekeepingType Get(Expression<Func<BeekeepingType, bool>> expression)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.BeekeepingTypes.Where(expression).FirstOrDefault();
            }
        }

        public List<BeekeepingType> GetAll()
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.BeekeepingTypes.ToList();
            }
        }

        public List<BeekeepingType> GetAll(Expression<Func<BeekeepingType, bool>> expression)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.BeekeepingTypes.Where(expression).ToList();
            }
        }

        public BeekeepingType GetById(int id)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.BeekeepingTypes.Find(id);
            }
        }

        public void Insert(BeekeepingType entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.BeekeepingTypes.Attach(entity);
                db.Entry(entity).State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Update(BeekeepingType entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.BeekeepingTypes.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
