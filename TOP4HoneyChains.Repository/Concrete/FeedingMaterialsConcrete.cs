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
    public class FeedingMaterialsConcrete : IDatabaseBusiness<FeedingMaterial>
    {
        public void Delete(FeedingMaterial entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.FeedingMaterials.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                var entity = db.FeedingMaterials.Find(id);
                db.FeedingMaterials.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public FeedingMaterial Get(Expression<Func<FeedingMaterial, bool>> expression)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.FeedingMaterials.Where(expression).FirstOrDefault();
            }
        }

        public List<FeedingMaterial> GetAll()
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.FeedingMaterials.ToList();
            }
        }

        public List<FeedingMaterial> GetAll(Expression<Func<FeedingMaterial, bool>> expression)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.FeedingMaterials.Where(expression).ToList();
            }
        }

        public FeedingMaterial GetById(int id)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.FeedingMaterials.Find(id);
            }
        }

        public void Insert(FeedingMaterial entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.FeedingMaterials.Attach(entity);
                db.Entry(entity).State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Update(FeedingMaterial entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.FeedingMaterials.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
