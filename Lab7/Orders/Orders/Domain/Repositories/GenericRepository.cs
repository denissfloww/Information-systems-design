using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orders.Domain.Models;
using Orders.Infrastructure;

namespace Orders.Domain.Repositories
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        static DbContext _context;
        static DbSet<TEntity> _dbSet;

        static GenericRepository()
        {
            _context = new Context();
            _dbSet = _context.Set<TEntity>();
        }

        public static List<TEntity> Get()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public static List<TEntity> Get(Func<TEntity, bool> predicate)
        {
            return _dbSet.AsNoTracking().Where(predicate).ToList();
        }
        public static TEntity GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public static void Create(TEntity item)
        {
            _dbSet.Add(item);
            _context.SaveChanges();
        }
        public static void Update(TEntity item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public static void Remove(TEntity item)
        {
            _dbSet.Remove(item);
            _context.SaveChanges();
        }
    }
}
