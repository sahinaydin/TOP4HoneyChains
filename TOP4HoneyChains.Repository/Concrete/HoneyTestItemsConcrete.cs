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
    public class HoneyTestItemsConcrete : IDatabaseBusiness<HoneyTestItem>
    {
        public void Delete(HoneyTestItem entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.HoneyTestItems.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                var entity = db.HoneyTestItems.Find(id);
                db.HoneyTestItems.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public HoneyTestItem Get(Expression<Func<HoneyTestItem, bool>> expression)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.HoneyTestItems.Where(expression).FirstOrDefault();
            }
        }

        public List<HoneyTestItem> GetAll()
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.HoneyTestItems.ToList();
            }
        }

        public List<HoneyTestItem> GetAll(Expression<Func<HoneyTestItem, bool>> expression)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.HoneyTestItems.Where(expression).ToList();
            }
        }

        public HoneyTestItem GetById(int id)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.HoneyTestItems.Find(id);
            }
        }

        public void Insert(HoneyTestItem entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.HoneyTestItems.Attach(entity);
                db.Entry(entity).State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Update(HoneyTestItem entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.HoneyTestItems.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
