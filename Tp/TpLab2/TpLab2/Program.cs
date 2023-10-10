using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using TpLab2;

namespace TpLab2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int selectedIndex = 0;
            bool salir = false;
            Console.CursorVisible = false;
            while (salir == false)
            {
                Console.Clear();
                Console.ResetColor();
                Console.WriteLine("Seleccione una opción");
                Console.WriteLine("---------------------");

                for (int i = 0; i < Constants.menuOptions.Length; i++)
                {
                    if (i == selectedIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.Write((char)2 + " ");
                    }
                    else
                    {
                        Console.ResetColor();
                        Console.Write("  ");
                    }

                    Console.WriteLine(Constants.menuOptions[i]);
                }

                ConsoleKeyInfo keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        selectedIndex = Math.Max(0, selectedIndex - 1);
                        break;
                    case ConsoleKey.DownArrow:
                        selectedIndex = Math.Min(Constants.menuOptions.Length - 1, selectedIndex + 1);
                        break;
                    case ConsoleKey.Enter:
                    case ConsoleKey.Spacebar:
                        if (selectedIndex == Constants.menuOptions.Length - 1)
                            salir = true;
                        else
                            HandleMenuOption(Constants.menuOptions[selectedIndex]);
                        break;
                }
            }
        }

        public static void Menu(string userInput)
        {
            switch (userInput)
            {
                case "Despachar":
                    {
                        try
                        {
                            DESPACHAR.Run();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        Console.ReadKey();
                        break;
                    }
                case "Ver despachos realizados":
                    {

                    }
                    break;
            }
        }

        static void HandleMenuOption(string option)
        {
            // Aquí puedes implementar la lógica para manejar cada opción del menú
            Console.Clear();
            Console.WriteLine($"Seleccionaste: {option}");
            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey();
            Menu(option);
        }
    }
}
