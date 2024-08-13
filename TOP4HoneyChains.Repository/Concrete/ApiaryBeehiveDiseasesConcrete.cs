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
    public class ApiaryBeehiveDiseasesConcrete : IDatabaseBusiness<ApiaryBeehiveDiseas>
    {
        public void Delete(ApiaryBeehiveDiseas entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.ApiaryBeehiveDiseases.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                var entity = db.ApiaryBeehiveDiseases.Find(id);
                db.ApiaryBeehiveDiseases.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public ApiaryBeehiveDiseas Get(Expression<Func<ApiaryBeehiveDiseas, bool>> expression)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.ApiaryBeehiveDiseases.Where(expression).FirstOrDefault();
            }
        }

        public List<ApiaryBeehiveDiseas> GetAll()
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.ApiaryBeehiveDiseases.ToList();
            }
        }

        public List<ApiaryBeehiveDiseas> GetAll(Expression<Func<ApiaryBeehiveDiseas, bool>> expression)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.ApiaryBeehiveDiseases.Where(expression).ToList();
            }
        }

        public ApiaryBeehiveDiseas GetById(int id)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.ApiaryBeehiveDiseases.Find(id);
            }
        }

        public void Insert(ApiaryBeehiveDiseas entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.ApiaryBeehiveDiseases.Attach(entity);
                db.Entry(entity).State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Update(ApiaryBeehiveDiseas entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.ApiaryBeehiveDiseases.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
