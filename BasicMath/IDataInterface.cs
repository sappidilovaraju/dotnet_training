using System.Collections.Generic;

namespace BasicMath
{
    public interface IDataInterface<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);
        void Add(TEntity entity);
        void Delete(TEntity entity);
    }
}
