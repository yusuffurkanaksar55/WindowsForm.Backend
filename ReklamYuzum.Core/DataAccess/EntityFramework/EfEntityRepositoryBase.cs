using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using ReklamYuzum.Core.Entites;

namespace ReklamYuzum.Core.DataAccess.EntityFramework
{
	public class EfEntityRepositoryBase<TEntity,TContext> :IEntityRepositoryBase<TEntity>
	where TEntity : class,IEntity,new()
	where TContext:DbContext,new()
	{
		public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filterExpression = null)
		{
			using (var context = new TContext())
			{
				return filterExpression == null
					? context.Set<TEntity>().ToList()
					: context.Set<TEntity>().Where(filterExpression).ToList();
			}
		}

		public TEntity GetById(int id)
		{
			using (var context = new TContext())
			{
				return context.Set<TEntity>().Find(id);
			}
		}

		public TEntity Get(Expression<Func<TEntity, bool>> filterExpression)
		{
			using (var context = new TContext())
			{
				return context.Set<TEntity>().FirstOrDefault(filterExpression);
			}
		}

		public TEntity Add(TEntity entity)
		{
			using (var context=new TContext())
			{
				var addedEntity = context.Entry(entity);
				addedEntity.State= EntityState.Added;
				context.SaveChanges();
				return entity;
			}
		}

		public TEntity Update(TEntity entity)
		{
			using (var context = new TContext())
			{
				var updatedEntity = context.Entry(entity);
				updatedEntity.State = EntityState.Modified;
				context.SaveChanges();
				return entity;
			}
		}

		public void Delete(TEntity entity)
		{
			using (var context = new TContext())
			{
				var deltedEntity = context.Entry(entity);
				deltedEntity.State = EntityState.Modified;
				context.SaveChanges();
			}
		}
	}
}
