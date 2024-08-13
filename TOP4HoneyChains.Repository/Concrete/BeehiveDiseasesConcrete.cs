using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TOP4HoneyChains.Entities;
using TOP4HoneyChains.Repository.Abstract;

namespace TOP4HoneyChains.Repository.Concrete
{
    public class BeehiveDiseasesConcrete : IDatabaseBusiness<BeehiveDiseas>
    {
        public void Delete(BeehiveDiseas entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.BeehiveDiseases.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                var entity = db.BeehiveDiseases.Find(id);
                db.BeehiveDiseases.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public BeehiveDiseas Get(Expression<Func<BeehiveDiseas, bool>> expression)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.BeehiveDiseases.Where(expression).FirstOrDefault();
            }
        }

        public List<BeehiveDiseas> GetAll()
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.BeehiveDiseases.ToList();
            }
        }

        public List<BeehiveDiseas> GetAll(Expression<Func<BeehiveDiseas, bool>> expression)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.BeehiveDiseases.Where(expression).ToList();
            }
        }

        public BeehiveDiseas GetById(int id)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.BeehiveDiseases.Find(id);
            }
        }

        public void Insert(BeehiveDiseas entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.BeehiveDiseases.Attach(entity);
                db.Entry(entity).State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Update(BeehiveDiseas entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.BeehiveDiseases.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
