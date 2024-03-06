using System.Linq.Expressions;

namespace fileupload.Data
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected AppDbContext _app;
        public RepositoryBase(AppDbContext app)
        {
            _app = app;
        }

        public void Create(T entity)
        {
            _app.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _app.Set<T>().Remove(entity);
        }

        public IEnumerable<T> FindAll()
        {
            return _app.Set<T>();
        }

        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _app.Set<T>().Where(expression);
        }

        public T GetByEmail()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            return _app.Set<T>().Find(id);
        }

        public void Save()
        {
            _app.SaveChanges();
        }

        public void Update(T entity)
        {
            _app.Set<T>().Update(entity);
        }
    }
}
