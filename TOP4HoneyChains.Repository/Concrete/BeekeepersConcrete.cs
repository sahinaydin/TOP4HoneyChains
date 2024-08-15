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
    public class BeekeepersConcrete : IDatabaseBusiness<Beekeeper>
    {
        public void Delete(Beekeeper entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.Beekeepers.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                var entity = db.Beekeepers.Find(id);
                db.Beekeepers.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public Beekeeper Get(Expression<Func<Beekeeper, bool>> expression)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.Beekeepers.Where(expression).FirstOrDefault();
            }
        }

        public List<Beekeeper> GetAll()
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.Beekeepers.ToList();
            }
        }

        public List<Beekeeper> GetAll(Expression<Func<Beekeeper, bool>> expression)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.Beekeepers.Where(expression).ToList();
            }
        }

        public Beekeeper GetById(int id)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.Beekeepers.Find(id);
            }
        }

        public void Insert(Beekeeper entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.Beekeepers.Attach(entity);
                db.Entry(entity).State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Update(Beekeeper entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.Beekeepers.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public Beekeeper GetByIdentityNumber(string identitynumber)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.Beekeepers.Where(b=>b.IdentityNumber == identitynumber).FirstOrDefault();
            }
        }
    }
}
