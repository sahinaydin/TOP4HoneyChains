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
    public class ApiaryHoneyProductionsConcrete : IDatabaseBusiness<ApiaryHoneyProduction>
    {
        public void Delete(ApiaryHoneyProduction entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.ApiaryHoneyProductions.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                var entity = db.ApiaryHoneyProductions.Find(id);
                db.ApiaryHoneyProductions.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public ApiaryHoneyProduction Get(Expression<Func<ApiaryHoneyProduction, bool>> expression)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.ApiaryHoneyProductions.Where(expression).FirstOrDefault();
            }
        }

        public List<ApiaryHoneyProduction> GetAll()
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.ApiaryHoneyProductions.ToList();
            }
        }

        public List<ApiaryHoneyProduction> GetAll(Expression<Func<ApiaryHoneyProduction, bool>> expression)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.ApiaryHoneyProductions.Where(expression).ToList();
            }
        }

        public ApiaryHoneyProduction GetById(int id)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.ApiaryHoneyProductions.Find(id);
            }
        }

        public void Insert(ApiaryHoneyProduction entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.ApiaryHoneyProductions.Attach(entity);
                db.Entry(entity).State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Update(ApiaryHoneyProduction entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.ApiaryHoneyProductions.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
