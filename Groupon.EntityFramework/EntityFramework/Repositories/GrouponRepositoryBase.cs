using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Groupon.EntityFramework.Repositories
{
    public abstract class GrouponRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<GrouponDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected GrouponRepositoryBase(IDbContextProvider<GrouponDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class GrouponRepositoryBase<TEntity> : GrouponRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected GrouponRepositoryBase(IDbContextProvider<GrouponDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
