using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

    public static int LeerOpcionMenuKey(string menu)
    {
        string opcionMenu = string.Empty;

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
        else if (tecla.Key == ConsoleKey.Enter)
        {
            if (string.IsNullOrEmpty(opcionMenu) || opcionMenu == "0")
            {
                Console.Beep();
                Console.WriteLine("\nOpción no válida. Presiona una tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(menu);
                opcionMenu = string.Empty;
            }
            else
            {
                Console.WriteLine();
                return int.Parse(opcionMenu);
            }
        }
    }
        // while (true)
        // {
        //     ConsoleKeyInfo tecla = Console.ReadKey(intercept: true);
        //     char opcion = (char)tecla.KeyChar;
        //     if ((int)char.GetNumericValue(opcion)>= 1)
        //     {
        //         return (int)char.GetNumericValue(opcion);
        //     }
        //     else
        //     {
        //         Console.Write("\nOpción no válida");
        //         Console.ReadKey();
        //         Console.Clear();
        //         Console.WriteLine(menu);
        //     }
        // }
    //     string opcionMenu = string.Empty;
    //     while(true)
    //     {
    //         int opcion = LeerEntero();
    //         opcionMenu += opcion.ToString();
    //         //Console.Write(opcionMenu);
    //         ConsoleKeyInfo tecla = Console.ReadKey(intercept: true);
    //         if(tecla.Key == ConsoleKey.Enter){
    //             Console.WriteLine(opcionMenu);
    //             return int.Parse(opcionMenu);

    //         } else if (tecla.Key == ConsoleKey.Enter && opcionMenu == "0")
    //         {
    //             Console.WriteLine("Por favor selecciona una opción válida");
    //         }
    //     }
    // }

    // public static int LeerEntero(){
   
    //         ConsoleKeyInfo tecla = Console.ReadKey(intercept:true);
    //         if(char.IsDigit(tecla.KeyChar)){
    //             return (int)char.GetNumericValue(tecla.KeyChar);
    //         }else{
    //             Console.Beep();
    //             LeerEntero();
    //         }
    //         return 0;
        
    }
}