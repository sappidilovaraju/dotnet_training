using System.Collections.Generic;

namespace BasicMath_V2
{
    public interface IDbOperation<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);
        void Add(TEntity entity);
        void Delete(TEntity entity);
    }
}
