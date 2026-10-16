using System.Linq;

namespace JT_CMS.Repositories.Abstractions;

public interface IQueryableRepository<TEntity> where TEntity : IEntity
{
    IQueryable<TEntity> AsQueryable();
}
