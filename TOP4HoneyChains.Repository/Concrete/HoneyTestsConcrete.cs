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
    public class HoneyTestsConcrete : IDatabaseBusiness<HoneyTest>
    {
        public void Delete(HoneyTest entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.HoneyTests.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                var entity = db.HoneyTests.Find(id);
                db.HoneyTests.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public HoneyTest Get(Expression<Func<HoneyTest, bool>> expression)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.HoneyTests.Where(expression).FirstOrDefault();
            }
        }

        public List<HoneyTest> GetAll()
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.HoneyTests.ToList();
            }
        }

        public List<HoneyTest> GetAll(Expression<Func<HoneyTest, bool>> expression)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.HoneyTests.Where(expression).ToList();
            }
        }

        public HoneyTest GetById(int id)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.HoneyTests.Find(id);
            }
        }

        public void Insert(HoneyTest entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.HoneyTests.Attach(entity);
                db.Entry(entity).State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Update(HoneyTest entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.HoneyTests.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
