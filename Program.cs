using seriesR.src.Controller;

namespace seriesR
{
  public class Program
  {
    static SeriesController seriesController = new SeriesController();

    public static void Main()
    {
      string userCode = HandleUserCode();

      System.Console.WriteLine(userCode);

      while (userCode.ToUpper() != "X")
      {
        switch (userCode)
        {
          case "1":
            seriesController.FindAll();
            break;
          case "2":
            seriesController.Save();
            break;
          case "3":
            seriesController.Update();
            break;
          case "4":
            seriesController.Delete();
            break;
          case "5":
            seriesController.FindById();
            break;
          case "C":
            Console.Clear();
            break;
          default:
            throw new ArgumentOutOfRangeException();
        }

        userCode = HandleUserCode();
      }

    }

    private static string HandleUserCode()
    {
      Console.WriteLine();
      Console.WriteLine("DIO Séries a seu dispor!!!");
      Console.WriteLine("Informe a opção desejada:");

      Console.WriteLine("1- Listar séries");
      Console.WriteLine("2- Inserir nova série");
      Console.WriteLine("3- Atualizar série");
      Console.WriteLine("4- Excluir série");
      Console.WriteLine("5- Visualizar série");
      Console.WriteLine("C- Limpar Tela");
      Console.WriteLine("X- Sair");
      Console.WriteLine();

      string? userCode = System.Console.ReadLine();
      Console.WriteLine();

      if (userCode == null) return "";

      return userCode.ToUpper();
    }
  }
}