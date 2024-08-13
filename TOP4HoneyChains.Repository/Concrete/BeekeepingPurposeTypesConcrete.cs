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
    public class BeekeepingPurposeTypesConcrete : IDatabaseBusiness<BeekeepingPurposeType>
    {
        public void Delete(BeekeepingPurposeType entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.BeekeepingPurposeTypes.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                var entity = db.BeekeepingPurposeTypes.Find(id);
                db.BeekeepingPurposeTypes.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public BeekeepingPurposeType Get(Expression<Func<BeekeepingPurposeType, bool>> expression)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.BeekeepingPurposeTypes.Where(expression).FirstOrDefault();
            }
        }

        public List<BeekeepingPurposeType> GetAll()
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.BeekeepingPurposeTypes.ToList();
            }
        }

        public List<BeekeepingPurposeType> GetAll(Expression<Func<BeekeepingPurposeType, bool>> expression)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.BeekeepingPurposeTypes.Where(expression).ToList();
            }
        }

        public BeekeepingPurposeType GetById(int id)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.BeekeepingPurposeTypes.Find(id);
            }
        }

        public void Insert(BeekeepingPurposeType entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.BeekeepingPurposeTypes.Attach(entity);
                db.Entry(entity).State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Update(BeekeepingPurposeType entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.BeekeepingPurposeTypes.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
