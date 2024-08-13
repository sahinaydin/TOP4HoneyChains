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
    public class ApiaryBeehivesConcrete : IDatabaseBusiness<ApiaryBeehive>
    {
        public void Delete(ApiaryBeehive entity)
        {
            using(var db = new TOP4HoneyChainsDbEntities())
            {
                db.ApiaryBeehives.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                var entity = db.ApiaryBeehives.Find(id);
                db.ApiaryBeehives.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public ApiaryBeehive Get(Expression<Func<ApiaryBeehive, bool>> expression)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.ApiaryBeehives.Where(expression).FirstOrDefault();
            }
        }

        public List<ApiaryBeehive> GetAll()
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.ApiaryBeehives.ToList();
            }
        }

        public List<ApiaryBeehive> GetAll(Expression<Func<ApiaryBeehive, bool>> expression)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.ApiaryBeehives.Where(expression).ToList();
            }
        }

        public ApiaryBeehive GetById(int id)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.ApiaryBeehives.Find(id);
            }
        }

        public void Insert(ApiaryBeehive entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.ApiaryBeehives.Attach(entity);
                db.Entry(entity).State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Update(ApiaryBeehive entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.ApiaryBeehives.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
