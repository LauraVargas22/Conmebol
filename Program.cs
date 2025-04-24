using oop;
using oop.Equipo;
internal class Program
{
    private static void Main(string[] args)
    {
        string menu = "1. Registrar Club\n2. Registrar Jugador\n3. Listar Clubes\n4. Listar Jugadores \n 5. Salir \n Seleccione una opción: ";
        Console.Clear();
        Console.WriteLine("Sistema de gestión de la Conmebol Libertadores.");
        Console.WriteLine(menu);
        Utilidades.LeerOpcionMenuKey(menu);
        
        // List<Club> clubes = new List<Club>();
        // bool continuar = true;
        // Club club;

        // do
        // {
        //     club = new Club();
        //     Console.Clear();

        //     Console.WriteLine("Bienvenido al sistema de gestión de jugadores de fútbol.");

        //     Console.WriteLine("Por favor, ingrese el ID del club.");
        //     club.Id = Console.ReadLine();
        //     Console.WriteLine("Por favor, ingrese el nombre del club.");
        //     club.Nombre = Console.ReadLine()?.ToUpper();

        //     clubes.Add(club);

        //     Console.WriteLine("¿Desea continuar? (S/N)");
        //     continuar = Utilidades.LeerTecla();
        // } while (continuar);

        // Console.Clear();
        // Console.WriteLine("Lista de clubes registrados:");
        // foreach(Club myClub in clubes)
        // {
        //     Console.WriteLine($"ID: {myClub.Id}, Nombre: {myClub.Nombre}");
        // }
    }
}
