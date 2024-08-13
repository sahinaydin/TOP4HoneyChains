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
    public class ProductionPeriodsConcrete : IDatabaseBusiness<ProductionPeriod>
    {
        public void Delete(ProductionPeriod entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.ProductionPeriods.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                var entity = db.ProductionPeriods.Find(id);
                db.ProductionPeriods.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public ProductionPeriod Get(Expression<Func<ProductionPeriod, bool>> expression)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.ProductionPeriods.Where(expression).FirstOrDefault();
            }
        }

        public List<ProductionPeriod> GetAll()
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.ProductionPeriods.ToList();
            }
        }

        public List<ProductionPeriod> GetAll(Expression<Func<ProductionPeriod, bool>> expression)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.ProductionPeriods.Where(expression).ToList();
            }
        }

        public ProductionPeriod GetById(int id)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.ProductionPeriods.Find(id);
            }
        }

        public void Insert(ProductionPeriod entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.ProductionPeriods.Attach(entity);
                db.Entry(entity).State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Update(ProductionPeriod entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.ProductionPeriods.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
