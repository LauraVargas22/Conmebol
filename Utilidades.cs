using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Figgle;

namespace oop;
public class Utilidades
{
    public static bool LeerTecla()
    {
        while (true)
        {
            ConsoleKeyInfo tecla = Console.ReadKey(intercept: true);
            char respuesta = char.ToUpper(tecla.KeyChar);
            switch (respuesta)
            {
                case 'S':
                    return true;
                case 'N':
                    return false;
                default:
                    Console.WriteLine("Respuesta no válida. Por favor, ingrese 's' o 'n'.");
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

    public static int LeerCaracter(string titulo = "Sistema de gestión de la ",string[]? opcionesMenu= null)
    {
        string opcionMenu = string.Empty;
        Console.Clear();
        EscribirCentrado(titulo,ConsoleColor.Magenta);

        if (opcionesMenu != null)
            {
                foreach (var opcion in opcionesMenu)
                {
                    Console.WriteLine($"{"",-10}{opcion,0}");
                }
            }
        Console.Write($"{"",-10}{"Seleccione una Opcion:",-10}");
        Console.Write($"{"",-3}");

        while (true)
        {
            ConsoleKeyInfo tecla = Console.ReadKey(intercept: true);

            if (char.IsDigit(tecla.KeyChar))
            {
                opcionMenu += tecla.KeyChar;
                Console.Write(tecla.KeyChar);
            }
            else if (tecla.Key == ConsoleKey.Backspace && opcionMenu.Length > 0) //Borrar el último carácter escrito "Backspace" tecla borrar
            {
                opcionMenu = opcionMenu.Substring(0, opcionMenu.Length - 1);
                Console.Write("\b \b");
            }
            else if (tecla.Key == ConsoleKey.Enter && opcionMenu.Length > 0)
            {
                Console.WriteLine();
                return int.Parse(opcionMenu);
            }
            else 
            {
                Console.Beep();
            }
        }
    }

    public static void EscribirCentrado(string texto, ConsoleColor color)
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
            int espaciosIzquierda = Math.Max((anchoConsola - linea.Length) / 2, 0 );
            Console.WriteLine(new string(' ', espaciosIzquierda) + linea);
        }

        Console.ResetColor();
    }
}