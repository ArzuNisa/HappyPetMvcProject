public interface IGenericDal<T> where T : class
{
    Task Add(T entity);
    Task Delete(T entity);
    Task Update(T entity);
    Task<T> GetByID(int id);
    Task<List<T>> GetAll();
}
