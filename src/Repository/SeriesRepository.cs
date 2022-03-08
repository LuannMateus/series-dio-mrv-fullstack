using seriesR.src.Domain;
using seriesR.src.Interfaces;


namespace seriesR.src.Repository
{

  public class SeriesRepository : IRepository<Series>
  {
    private List<Series> seriesList = new List<Series>();

    public List<Series> FindAll()
    {
      return seriesList;
    }

    public Series FindById(int id)
    {
      return seriesList[id];
    }

    public void Save(Series entity)
    {
      seriesList.Add(entity);
    }

    public void Update(int id, Series entity)
    {
      seriesList[id] = entity;
    }

    public void DeleteById(int id)
    {
      seriesList[id].Remove();
    }

    public int NextId()
    {
      return seriesList.Count;
    }

  }
}