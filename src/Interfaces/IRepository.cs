namespace seriesR.src.Interfaces
{
  public interface IRepository<T>
  {
    List<T> FindAll();

    T FindById(int id);

    void Save(T entity);

    void DeleteById(int id);

    void Update(int id, T entity);

    int NextId();
  }
}