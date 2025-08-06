using Liga_futbol.Src.Shared.Helpers;

internal class Program
{
    private static void Main(string[] args)
    {
        var dbContext = DbContextFactory.Create();
        Console.WriteLine("DbContext creado exitosamente.");
    }
}