using Figgle;

namespace oop;

public class Utilidades
{
    public static bool LeerTecla()
    {
        while (true)
        {
            ConsoleKeyInfo tecla = Console.ReadKey(intercept: true);
            char opcion = char.ToUpper(tecla.KeyChar);
            switch (opcion)
            {
                case 'S':
                    return true;
                case 'N':
                    return false;
                default:
                    Console.Write("\nTecla no válida. Presione S o N: ");
                    break;
            }

        }
    }

    public static int LeerOpcionMenu(string menu)
    {
        while (true)
        {
            try{
                Console.Write("\nSeleccione una opción: ");
                string opcion = Console.ReadLine() ?? string.Empty;
                if (int.Parse(opcion)>= 1)
                {
                    return int.Parse(opcion);
                }
                else
                {
                    Console.Write("\nOpción no válida");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine(menu);
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
    public static int LeerCaracter(string titulo = "Sistema de gestión de la ",string[]? opcionesMenu= null){

            string entrada = string.Empty;
            Console.Clear();
            EscribirCentrado(titulo,ConsoleColor.Magenta);
            //MostrarFiggleCentrado("Conmebol Libertadores.", FiggleFonts.Small, ConsoleColor.Magenta);
            if (opcionesMenu != null)
            {
                foreach (var opcion in opcionesMenu)
                {
                    Console.WriteLine($"{"",-10}{opcion,0}");
                }
            }
            Console.Write($"{"",-10}{"Seleccione una Opcion:",-10}");
            Console.Write($"{"",-3}");
            //EscribirCentrado(titulo,ConsoleColor.Magenta);
            while (true)
            {
                ConsoleKeyInfo tecla = Console.ReadKey(intercept: true);
                
                // Si es un número, agregarlo a la cadena
                if (char.IsDigit(tecla.KeyChar))
                {
                    entrada += tecla.KeyChar;
                    Console.Write(tecla.KeyChar);
                }
                // Si es Backspace, eliminar el último carácter
                else if (tecla.Key == ConsoleKey.Backspace && entrada.Length > 0)
                {  
                    entrada = entrada.Remove(entrada.Length - 1);
                    Console.Write("\b \b"); // Borra visualmente en consola
                }
                // Si presiona Enter y hay algo escrito, devolver el número
                else if (tecla.Key == ConsoleKey.Enter && entrada.Length > 0)
                {
                    Console.WriteLine(); // Salto de línea tras Enter
                    return int.Parse(entrada);
                }
                else
                {
                    // Cualquier otra tecla no se permite
                    Console.Beep(); // Sonido de error
                }
            }
        
    }
    public static void EscribirCentrado(string texto,ConsoleColor color)
    {
        int anchoConsola = Console.WindowWidth;
        int espaciosIzquierda = (anchoConsola - texto.Length) / 2;

        Console.ForegroundColor = color;
        Console.WriteLine(new string(' ', Math.Max(0, espaciosIzquierda)) + texto);
        Console.ResetColor();
    }
    public static void MostrarFiggleCentrado(string texto, FiggleFont fuente, ConsoleColor color = ConsoleColor.White)
    {
        string textoFiggle = fuente.Render(texto);
        string[] lineas = textoFiggle.Split('\n');

        int anchoConsola = Console.WindowWidth;

        Console.ForegroundColor = color;

        foreach (string linea in lineas)
        {
            int espaciosIzquierda = Math.Max((anchoConsola - linea.Length) / 2, 0);
            Console.WriteLine(new string(' ', espaciosIzquierda) + linea);
        }

        Console.ResetColor();
    }
}