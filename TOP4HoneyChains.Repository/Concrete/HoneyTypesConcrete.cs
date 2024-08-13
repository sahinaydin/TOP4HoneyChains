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
    public class HoneyTypesConcrete : IDatabaseBusiness<HoneyType>
    {
        public void Delete(HoneyType entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.HoneyTypes.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                var entity = db.HoneyTypes.Find(id);
                db.HoneyTypes.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public HoneyType Get(Expression<Func<HoneyType, bool>> expression)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.HoneyTypes.Where(expression).FirstOrDefault();
            }
        }

        public List<HoneyType> GetAll()
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.HoneyTypes.ToList();
            }
        }

        public List<HoneyType> GetAll(Expression<Func<HoneyType, bool>> expression)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.HoneyTypes.Where(expression).ToList();
            }
        }

        public HoneyType GetById(int id)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.HoneyTypes.Find(id);
            }
        }

        public void Insert(HoneyType entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.HoneyTypes.Attach(entity);
                db.Entry(entity).State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Update(HoneyType entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.HoneyTypes.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
