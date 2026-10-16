namespace JT_CMS.Repositories.Abstractions;

public interface IAuditableEntityRepository<TEntity> : IEntityRepository<TEntity> where TEntity : IAuditableEntity
{
}
