using System.Collections.Generic;

namespace DependencyInjection1.Models.Repository
{
    public interface IDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();

        void Add(Employee employee);
    }
}
