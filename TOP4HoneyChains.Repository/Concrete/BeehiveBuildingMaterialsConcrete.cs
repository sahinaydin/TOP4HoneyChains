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
    public class BeehiveBuildingMaterialsConcrete : IDatabaseBusiness<BeehiveBuildingMaterial>
    {
        public void Delete(BeehiveBuildingMaterial entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.BeehiveBuildingMaterials.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                var entity = db.BeehiveBuildingMaterials.Find(id);
                db.BeehiveBuildingMaterials.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public BeehiveBuildingMaterial Get(Expression<Func<BeehiveBuildingMaterial, bool>> expression)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.BeehiveBuildingMaterials.Where(expression).FirstOrDefault();
            }
        }

        public List<BeehiveBuildingMaterial> GetAll()
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.BeehiveBuildingMaterials.ToList();
            }
        }

        public List<BeehiveBuildingMaterial> GetAll(Expression<Func<BeehiveBuildingMaterial, bool>> expression)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.BeehiveBuildingMaterials.Where(expression).ToList();
            }
        }

        public BeehiveBuildingMaterial GetById(int id)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                return db.BeehiveBuildingMaterials.Find(id);
            }
        }

        public void Insert(BeehiveBuildingMaterial entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.BeehiveBuildingMaterials.Attach(entity);
                db.Entry(entity).State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Update(BeehiveBuildingMaterial entity)
        {
            using (var db = new TOP4HoneyChainsDbEntities())
            {
                db.BeehiveBuildingMaterials.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
