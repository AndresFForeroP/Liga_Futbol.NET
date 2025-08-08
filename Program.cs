using Liga_futbol.Src.Shared.Helpers;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var dbContext = DbContextFactory.Create();
        Console.WriteLine("DbContext creado exitosamente.");
        var equipo = dbContext.Equipo.ToList();
    }
}