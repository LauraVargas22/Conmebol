using oop;
using oop.Equipo;
internal class Program
{
    public static bool continuar;

    public static Club club { get; private set; }

    private static void Main(string[] args)
    {
        List<Club> clubes = new List<Club>();
        bool continuar = true;
        Console.Clear();
        string[] opcionesMenu = {
            "1. Registrar Club",
            "2. Registrar Jugador",
            "3. Listar Clubes",
            "4. Listar Jugadores",
            "5. Salir"
        };
        Console.WriteLine("Sistema de gestión de la Conmebol Libertadores.");
        switch(Utilidades.LeerCaracter("Sistema de gestión de la Libertadores", opcionesMenu))
        {
            case 1:
                do
                {
                    club = new Club();
                    Guid g = Guid.NewGuid();
                    Console.Clear();

                    Console.WriteLine("Bienvenido al sistema de gestión de jugadores de fútbol.");
                    Console.WriteLine("\n Resgistrar Club");
                    club.Id = g.ToString();
                    Console.WriteLine($"Id generado {g.ToString()}.");
                    Console.WriteLine("Por favor, ingrese el nombre del club.");
                    club.Nombre = Console.ReadLine()?.ToUpper();

                    clubes.Add(club);
                    Console.WriteLine(clubes.Count());
                    foreach(Club myClub in clubes)
                    {
                        Console.WriteLine($"ID: {myClub.Id}, Nombre: {myClub.Nombre}");
                    }
                    Console.WriteLine("¿Desea continuar? (S/N)");
                    continuar = Utilidades.LeerTecla();
                } while (continuar);
                break;
            case 2:
                do 
                {
                    Console.WriteLine("\n Resgistrar Jugadores");
                    string? clubJuego;
                    Console.WriteLine("Ingrese el club");
                    clubJuego = Console.ReadLine()?.ToUpper();
                    clubes.ForEach(c => {
                        if (c.Nombre == clubJuego?.ToUpper()){
                            Console.WriteLine($"Id: {c.Id} Nombre: {c.Nombre}");
                            Console.WriteLine("Ingrese el id del jugador: ");
                            string id = Console.ReadLine() ?? string.Empty;
                            Console.WriteLine("Ingrese el nombre del jugador: ");
                            string nombre = Console.ReadLine() ?? string.Empty;
                            Console.WriteLine("Ingrese el apellido del jugador: ");
                            string apellido = Console.ReadLine() ?? string.Empty;
                            Console.WriteLine("Ingrese el telefono del jugador: ");
                            string telefono = Console.ReadLine() ?? string.Empty;
                            Console.WriteLine("Ingrese el correo del jugador: ");
                            string correo = Console.ReadLine() ?? string.Empty;
                            Console.WriteLine("Ingrese el direccion del jugador: ");
                            string direccion = Console.ReadLine() ?? string.Empty;
                            Console.WriteLine("Ingrese el posicion del jugador: ");
                            string posicion = Console.ReadLine() ?? string.Empty;
                            Console.WriteLine("Ingrese el numero del jugador: ");
                            int numero = int.Parse(Console.ReadLine() ?? "0");
                            Player player = new Player(id, nombre, apellido, telefono, correo, direccion, posicion, numero);
                            c.Jugadores.Add(player);

                            Console.WriteLine("¿Desea continuar? (S/N)");
                            continuar = Utilidades.LeerTecla();
                        } 
                        else 
                        {
                            Console.WriteLine("El club no existe.");
                        }
                    });
                } while (continuar);
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("Lista de clubes registrados");
                break;
            case 4:
                Console.Write("Jugadores Registrados");
                break;
            case 5:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Error con la opción ingresada");
                break;
        }
        Main(args);

        // Console.Clear();
        // Console.WriteLine("Lista de clubes registrados:");
        // foreach(Club myClub in clubes)
        // {
        //     Console.WriteLine($"ID: {myClub.Id}, Nombre: {myClub.Nombre}");
        // }
    }
}
