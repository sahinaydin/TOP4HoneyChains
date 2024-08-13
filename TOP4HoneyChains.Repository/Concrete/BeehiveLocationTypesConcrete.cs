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
    public class BeehiveLocationTypesConcrete : IDatabaseBusiness<BeehiveLocationType>
    {
        public void Delete(BeehiveLocationType entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.BeehiveLocationTypes.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                var entity = db.BeehiveLocationTypes.Find(id);
                db.BeehiveLocationTypes.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public BeehiveLocationType Get(Expression<Func<BeehiveLocationType, bool>> expression)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.BeehiveLocationTypes.Where(expression).FirstOrDefault();
            }
        }

        public List<BeehiveLocationType> GetAll()
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.BeehiveLocationTypes.ToList();
            }
        }

        public List<BeehiveLocationType> GetAll(Expression<Func<BeehiveLocationType, bool>> expression)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.BeehiveLocationTypes.Where(expression).ToList();
            }
        }

        public BeehiveLocationType GetById(int id)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.BeehiveLocationTypes.Find(id);
            }
        }

        public void Insert(BeehiveLocationType entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.BeehiveLocationTypes.Attach(entity);
                db.Entry(entity).State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Update(BeehiveLocationType entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.BeehiveLocationTypes.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
