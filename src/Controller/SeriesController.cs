using seriesR.src.Domain;
using seriesR.src.Repository;
using seriesR.src.Utils;

namespace seriesR.src.Controller
{
  public class SeriesController
  {
    SeriesRepository seriesRepository = new SeriesRepository();

    public void FindAll()
    {
      List<Series> list = seriesRepository.FindAll();

      if (list.Count == 0)
      {
        System.Console.WriteLine("Nenhuma série cadastrada!");
        return;
      }

      foreach (Series item in list)
      {
        if (item.getExcluded()) return;

        System.Console.WriteLine(item);
      }
    }

    public void FindById()
    {
      Console.WriteLine("Digite o ID da série: ");
      int.TryParse(Console.ReadLine(), out int id);

      System.Console.WriteLine(seriesRepository.FindById(id));

    }

    public void Save()
    {
      Console.WriteLine("Inserir nova série");

      foreach (int i in Enum.GetValues(typeof(Genre)))
      {
        Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genre), i));
      }

      Console.Write("Digite o gênero entre as opções acima: ");
      int.TryParse(Console.ReadLine(), out int genreCode);

      Console.Write("Digite o Título da Série: ");
      string? title = Console.ReadLine();

      Console.Write("Digite o Ano de Início da Série: ");
      int.TryParse(Console.ReadLine(), out int year);

      Console.Write("Digite a Descrição da Série: ");
      string? description = Console.ReadLine();

      int id = seriesRepository.NextId();

      if (genreCode < 1 ||
          genreCode > 13 ||
          title == null ||
          year == 0 ||
          description == null)
      {
        return;
      }

      Series newSeries = new Series(
        id, genre: (Genre)genreCode, title, description, year, excluded: false);

      seriesRepository.Save(newSeries);
    }

    public void Update()
    {
      Console.WriteLine("Digite o ID da série: ");
      int.TryParse(Console.ReadLine(), out int id);

      foreach (int i in Enum.GetValues(typeof(Genre)))
      {
        Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genre), i));
      }

      Console.Write("Digite o gênero entre as opções acima: ");
      int.TryParse(Console.ReadLine(), out int genreCode);

      Console.Write("Digite o Título da Série: ");
      string? title = Console.ReadLine();

      Console.Write("Digite o Ano de Início da Série: ");
      int.TryParse(Console.ReadLine(), out int year);

      Console.Write("Digite a Descrição da Série: ");
      string? description = Console.ReadLine();

      if (genreCode < 1 ||
          genreCode > 13 ||
          title == null ||
          year == 0 ||
          description == null)
      {
        return;
      }

      Series newSeries = new Series(
        id, genre: (Genre)genreCode, title, description, year, excluded: false);

      seriesRepository.Update(id, newSeries);
    }

    public void Delete()
    {
      Console.WriteLine("Digite o ID da série: ");
      int.TryParse(Console.ReadLine(), out int id);

      seriesRepository.DeleteById(id);
    }
  }
}