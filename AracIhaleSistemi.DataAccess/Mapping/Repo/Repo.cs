using AracIhaleSistemi.DataAccess.Mapping.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AracIhaleSistemi.DataAccess.Mapping.Repo
{
    public class Repo<TEntity, TContext> : IRepo<TEntity> where TEntity : class, IEntity, new() where TContext : DbContext, new()
    {
        public async Task AddAsync(TEntity entity)
        {
            using (var context = new TContext())
            {
                var added = context.Entry(entity);
                added.State = EntityState.Added;
                var value = await context.SaveChangesAsync();
            }
        }
        public async Task UpdateAsync(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updated = context.Entry(entity);
                updated.State = EntityState.Modified;
                await context.SaveChangesAsync();
            }
        }
        public async Task DeleteAsync(TEntity entity)
        {
            using (var context = new TContext())
            {
                var deleted = context.Entry(entity);
                deleted.State = EntityState.Deleted;
                var value = await context.SaveChangesAsync();
            }
        }
        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var db = new TContext())
            {
                return await db.Set<TEntity>().SingleOrDefaultAsync(filter);
            }
        }
        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            List<TEntity> entities;
            using (var context = new TContext())
            {
                entities = await context.Set<TEntity>().ToListAsync();
            }
            return entities;
        }


        public TEntity Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                var added = context.Entry(entity);
                added.State = EntityState.Added;
                var value = context.SaveChanges();
                return added.Entity;
            }
        }
        public TEntity Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updated = context.Entry(entity);
                updated.State = EntityState.Modified;
                context.SaveChanges();
                return updated.Entity;
            }
        }
        public int Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var deleted = context.Entry(entity);
                deleted.State = EntityState.Deleted;
                var value = context.SaveChanges();
                return value;
            }
        }
        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var db = new TContext())
            {
                return filter == null ? db.Set<TEntity>().FirstOrDefault() : db.Set<TEntity>().Where(filter).FirstOrDefault();
            }
        }
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var db = new TContext())
            {
                return filter == null ? db.Set<TEntity>().ToList() : db.Set<TEntity>().Where(filter).ToList();
            }
        }
    }
}
