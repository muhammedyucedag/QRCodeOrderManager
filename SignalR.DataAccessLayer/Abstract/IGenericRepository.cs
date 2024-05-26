namespace SignalR.DataAccessLayer.Abstract;

public interface IGenericRepository<T> where T : class
{
    void Add(T entity);
    void Delete(T entity);
    void Update(T entity);
    T GetById(Guid id);
    List<T> GetListAll();
}