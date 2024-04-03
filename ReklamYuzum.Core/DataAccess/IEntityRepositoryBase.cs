using System.Linq.Expressions;
using ReklamYuzum.Core.Entites;

namespace ReklamYuzum.Core.DataAccess
{
	public interface IEntityRepositoryBase<TEntity> where TEntity : class, IEntity, new()
	{
		List<TEntity> GetAll(Expression<Func<TEntity,bool>> filterExpression=null);
		TEntity GetById(int id);
		TEntity Get(Expression<Func<TEntity,bool>> filterExpression);
		TEntity Add(TEntity entity);
		TEntity Update(TEntity entity);
		void Delete(TEntity entity);

	}
}
