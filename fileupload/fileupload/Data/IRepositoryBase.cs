using System.Linq.Expressions;

namespace fileupload.Data
{
    public interface IRepositoryBase<T>
    {
        T GetById(int id);
        T GetByEmail();
        IEnumerable<T> FindAll();
        IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Save();
        
    }
}
