using GreenHouse.Core;
using MyEFSample.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace MyEFSample.DAL.Concrete
{
    public class EFRepo<T> : IDeleteableRepo<T>, IInsertableRepo<T>, IUpdatetableRepo<T>, ISelectableRepo<T> where T : class
    {

        private readonly DbContext _db;
        private readonly DbSet<T> _table;
        public EFRepo(GreenHouseContext context)
        {
            _db = context;
            _table = context.Set<T>();
        }
        public EFRepo()
        {
            _db = new GreenHouseContext();
            _table = _db.Set<T>();
        }

        public T Add(T inserted)
        {
            //validation
            T returnsData = _table.Add(inserted);
            _db.SaveChanges();
            return returnsData;
        }

        public T HardDelete(T deleted)
        {
            T returnsData = _table.Attach(deleted);
            _db.Entry(deleted).State = EntityState.Deleted;
            _db.SaveChanges();
            return returnsData;

            //T returnsData = _table.Remove(deleted); ;
            //_db.SaveChanges();
            //return returnsData;
        }

        public List<T> SelectAll()
        {
            return _table.ToList();
        }

        public List<T> SelectAll(Expression<Func<T, bool>> filter)
        {
            return _table.Where(filter).ToList();
        }

        public List<T> SelectAllWithAsNoTracking()
        {
            return _table.AsNoTracking().ToList();
        }

        public List<T> SelectAllWithAsNoTracking(Expression<Func<T, bool>> filter)
        {
            return _table.Where(filter).AsNoTracking().ToList();
        }

        public List<T> SelectAllWithInclude(Expression<Func<T, bool>> filter, params string[] includes)
        {
            var query = _db.Set<T>().AsQueryable().Where(filter);
            query = includes.Aggregate(query, (current, inc) => current.Include(inc));
            return query.ToList();
        }

        public List<T> SelectAllWithInclude(params string[] includes)
        {
            var query = _db.Set<T>().AsQueryable();
            query = includes.Aggregate(query, (current, inc) => current.Include(inc));
            return query.ToList();
        }

        public T SelectByID(string ID)
        {
            return _table.Find(ID);
        }

        public List<T> SelectByID(Expression<Func<T, bool>> filter)
        {
            return _table.Where(filter).ToList();
        }

        public T SoftDelete(T deleted)
        {
            T returnsdata;
            if (deleted.GetType().GetProperty("AktifMi") != null)
            {
                //kolon var.
                T _entity = deleted;
                _entity.GetType().GetProperty("AktifMi").SetValue(_entity, false);
                returnsdata= Update(_entity);

            }
            else
            {
                //boyle bir kolon yok.
                DbEntityEntry dbEntityEntry = _db.Entry(deleted);
                #region MyRegion
                //if (dbEntityEntry.State != EntityState.Deleted)
                //{
                //    dbEntityEntry.State = EntityState.Deleted;
                //    _table.Attach(deleted);
                //    _table.Remove(deleted);
                //    _db.SaveChanges();
                //}
                //else
                //{
                //    HardDelete(deleted);
                //} 
                #endregion

                if (dbEntityEntry.State != EntityState.Deleted)
                {
                    dbEntityEntry.State = EntityState.Deleted;
                }
                returnsdata= HardDelete(deleted);
            }
            return returnsdata;
        }

        public T Update(T updated)
        {
            T returnsData = _table.Attach(updated);
            _db.Entry(updated).State = EntityState.Modified;
            _db.SaveChanges();
            return returnsData;
        }
    }
}
