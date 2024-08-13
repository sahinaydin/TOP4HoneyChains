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
    public class EducationLevelsConcrete : IDatabaseBusiness<EducationLevel>
    {
        public void Delete(EducationLevel entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.EducationLevels.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                var entity = db.EducationLevels.Find(id);
                db.EducationLevels.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public EducationLevel Get(Expression<Func<EducationLevel, bool>> expression)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.EducationLevels.Where(expression).FirstOrDefault();
            }
        }

        public List<EducationLevel> GetAll()
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.EducationLevels.ToList();
            }
        }

        public List<EducationLevel> GetAll(Expression<Func<EducationLevel, bool>> expression)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.EducationLevels.Where(expression).ToList();
            }
        }

        public EducationLevel GetById(int id)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.EducationLevels.Find(id);
            }
        }

        public void Insert(EducationLevel entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.EducationLevels.Attach(entity);
                db.Entry(entity).State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Update(EducationLevel entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.EducationLevels.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
