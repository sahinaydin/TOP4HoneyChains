using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TOP4HoneyChains.Entities;
using TOP4HoneyChains.Repository.Abstract;

namespace TOP4HoneyChains.Repository.Concrete
{
    public class ApiaryBeehivesFeedingProgramsConcrete : IDatabaseBusiness<ApiaryBeehivesFeedingProgram>
    {
        public void Delete(ApiaryBeehivesFeedingProgram entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.ApiaryBeehivesFeedingPrograms.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                var entity = db.ApiaryBeehivesFeedingPrograms.Find(id);
                db.ApiaryBeehivesFeedingPrograms.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public ApiaryBeehivesFeedingProgram Get(Expression<Func<ApiaryBeehivesFeedingProgram, bool>> expression)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.ApiaryBeehivesFeedingPrograms.Where(expression).FirstOrDefault();
            }
        }

        public List<ApiaryBeehivesFeedingProgram> GetAll()
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.ApiaryBeehivesFeedingPrograms.ToList();
            }
        }

        public List<ApiaryBeehivesFeedingProgram> GetAll(Expression<Func<ApiaryBeehivesFeedingProgram, bool>> expression)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.ApiaryBeehivesFeedingPrograms.Where(expression).ToList();
            }
        }

        public ApiaryBeehivesFeedingProgram GetById(int id)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.ApiaryBeehivesFeedingPrograms.Find(id);
            }
        }

        public void Insert(ApiaryBeehivesFeedingProgram entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.ApiaryBeehivesFeedingPrograms.Attach(entity);
                db.Entry(entity).State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Update(ApiaryBeehivesFeedingProgram entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.ApiaryBeehivesFeedingPrograms.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
