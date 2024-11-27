Console.Clear();
int color;

do
{
    try
    {
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Magenta;
        System.Console.WriteLine("****Menu****");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Red;
        System.Console.WriteLine("[1] Red");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine("[2] Green");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Blue;
        System.Console.WriteLine("[3] Blue");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Magenta;
        System.Console.WriteLine("[4] Salir \n");
        Console.ResetColor();

        color = Convert.ToInt16(Console.ReadLine());

        switch (color)
        {
            case 1:
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("\nEste el Red: El codigo es 255,0,0");
                Console.ResetColor();
                Console.ReadKey();
                break;
            case 2:
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine("\nEste es el Green: 0,255,0 ");
                Console.ResetColor();
                Console.ReadKey();
                break;
            case 3:
                Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine("\nEste es el Blue: 0,0,255 ");
                Console.ResetColor();
                Console.ReadKey();
                break;
            case 4:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                System.Console.WriteLine("SALIENDO...");
                Console.ResetColor();
                Console.ResetColor();
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Magenta;
                System.Console.WriteLine("\nIngresa una opcion valida = (^) =");
                Console.ResetColor();
                Console.ReadKey();
                break;
        }
    }
    catch
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        System.Console.WriteLine("\nIngrese un numero del * ^ *");
        color = 0;
        Console.ResetColor();
        Console.ReadKey();
    }
} while (color != 4);

