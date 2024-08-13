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
    public class HoneyDistributionTypesConcrete : IDatabaseBusiness<HoneyDistributionType>
    {
        public void Delete(HoneyDistributionType entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.HoneyDistributionTypes.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                var entity = db.HoneyDistributionTypes.Find(id);
                db.HoneyDistributionTypes.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public HoneyDistributionType Get(Expression<Func<HoneyDistributionType, bool>> expression)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.HoneyDistributionTypes.Where(expression).FirstOrDefault();
            }
        }

        public List<HoneyDistributionType> GetAll()
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.HoneyDistributionTypes.ToList();
            }
        }

        public List<HoneyDistributionType> GetAll(Expression<Func<HoneyDistributionType, bool>> expression)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.HoneyDistributionTypes.Where(expression).ToList();
            }
        }

        public HoneyDistributionType GetById(int id)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.HoneyDistributionTypes.Find(id);
            }
        }

        public void Insert(HoneyDistributionType entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.HoneyDistributionTypes.Attach(entity);
                db.Entry(entity).State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Update(HoneyDistributionType entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.HoneyDistributionTypes.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
