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
    public class ApiaryConcrete : IDatabaseBusiness<Apiary>
    {
        public void Delete(Apiary entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.Apiaries.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                var entity = db.Apiaries.Find(id);
                db.Apiaries.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public Apiary Get(Expression<Func<Apiary, bool>> expression)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.Apiaries.Where(expression).FirstOrDefault();
            }
        }

        public List<Apiary> GetAll()
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.Apiaries.ToList();
            }
        }

        public List<Apiary> GetAll(Expression<Func<Apiary, bool>> expression)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.Apiaries.Where(expression).ToList();
            }
        }

        public Apiary GetById(int id)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.Apiaries.Find(id);
            }
        }   

        public void Insert(Apiary entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.Apiaries.Attach(entity);
                db.Entry(entity).State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Update(Apiary entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.Apiaries.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
