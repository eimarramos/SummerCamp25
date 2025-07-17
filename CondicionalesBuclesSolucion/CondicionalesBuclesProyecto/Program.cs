internal class Program
{
    private static void Main(string[] args)
    {
        // 1º Opción usando Switch

        while (true)
        {
            Console.WriteLine("Introduce un número del 1 al 7 (o 0 para salir):");

            // Input del usuario.

            var userInput = Console.ReadLine();

            // Si el input es igual a 0 salimos del bucle.

            if (userInput == "0")
            {
                Console.WriteLine("Hasta Luego");
                break;
            }

            // Intentamos convertir el input a un número, en caso de no se posible numero se quedara a 0.

            int.TryParse(userInput, out int num);

            // Comprobamos que el numero este dentro del rango de 1 a 7 y mostramos el día, en caso de estar fuera de rango mostramos un error.

            if (num >= 1 && num <= 7)
            {
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Lunes");
                        break;
                    case 2:
                        Console.WriteLine("Martes");
                        break;
                    case 3:
                        Console.WriteLine("Miércoles");
                        break;
                    case 4:
                        Console.WriteLine("Jueves");
                        break;
                    case 5:
                        Console.WriteLine("Viernes");
                        break;
                    case 6:
                        Console.WriteLine("Sábado");
                        break;
                    case 7:
                        Console.WriteLine("Domingo");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Número inválido. Por favor, ingrese un número del 1 al 7.");
            }
        }

        // 2º Opción usando Enum

        /*

         Console.WriteLine("Ingrese un número del 1 al 7 (o 0 para salir): ");

         // Input del usuario.

         string? input = Console.ReadLine();

         // Comprobamos que el input no sea 0.

         while (input != "0")
         {
             // Intentamos convertir el input a un número, en caso de no se posible numero se quedara a 0.

             int.TryParse(input, out int numero);

             // Comprobamos que el numero este dentro del rango de 1 a 7.

             if (numero >= 1 && numero <= 7)
             {
                 Console.WriteLine($"{(Dias)(numero - 1)}");
             }
             else
             {
                 // Si el numero no esta dentro del rango, mostramos un mensaje de error.

                 Console.WriteLine("Número inválido. Por favor, ingrese un número del 1 al 7.");
             }

             // Pedimos al usuario que ingrese otro número.

             Console.WriteLine("Ingrese otro número del 1 al 7 (o 0 para salir): ");
             input = Console.ReadLine();
         }

         // Termina el programa.

         Console.WriteLine("¡Hasta luego!");
         */
    }
}

enum Dias
{
    Lunes,
    Martes,
    Miercoles,
    Jueves,
    Viernes,
    Sabado,
    Domingo
}