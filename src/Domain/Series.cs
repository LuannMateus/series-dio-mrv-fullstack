using seriesR.src.Utils;

namespace seriesR.src.Domain
{
  public class Series : Base
  {
    private Genre Genre
    {
      get; set;
    }
    private string Title { get; set; } = "";
    private string Description { get; set; } = "";

    private int Year { get; set; }

    private bool Excluded { get; set; }

    public Series(int id, Genre genre, string title, string description, int year, bool excluded)
    {
      this.Id = id;
      this.Genre = genre;
      this.Title = title;
      this.Description = description;
      this.Year = year;
      this.Excluded = excluded;
    }

    public override string ToString()
    {
      string stringValue = "";
      stringValue += "Gênero: " + this.Genre + Environment.NewLine;
      stringValue += "Titulo: " + this.Title + Environment.NewLine;
      stringValue += "Descrição: " + this.Description + Environment.NewLine;
      stringValue += "Ano de Início: " + this.Year + Environment.NewLine;
      stringValue += "Excluido: " + this.Excluded;

      return stringValue;
    }

    public string getTitle()
    {
      return this.Title;
    }

    public int getId()
    {
      return this.Id;
    }

    public bool getExcluded()
    {
      return this.Excluded;
    }

    public void Remove()
    {
      this.Excluded = true;
    }
  }
}