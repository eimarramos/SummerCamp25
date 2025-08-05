// Calculadora

// 1. Funciones

Func<decimal, decimal, decimal> Sumar = (numero1, numero2) => numero1 + numero2;

Func<decimal, decimal, decimal> Restar = (numero1, numero2) => numero1 - numero2;

Func<decimal, decimal, decimal> Multiplicar = (numero1, numero2) => numero1 * numero2;

Func<decimal, decimal, decimal> Dividir = (numero1, numero2) =>
{
    if (numero2 == 0)
    {
        Console.WriteLine("Error: División por cero no permitida.");
        return 0;
    }
    return numero1 / numero2;
};

Func<decimal> LeerNumero = () =>
{
    if (!decimal.TryParse(Console.ReadLine(), out decimal salida))
    {
        Console.WriteLine("Entrada no válida.");
        return 0;
    }
    return salida;
};

//Menu de opciones

Console.WriteLine("Calculadora");
Console.WriteLine("Seleccione una operación:");
Console.WriteLine("1. Sumar");
Console.WriteLine("2. Restar");
Console.WriteLine("3. Multiplicar");
Console.WriteLine("4. Dividir");
Console.WriteLine("5. Salir");

int opcion = 0;

while (opcion != 5)
{
    Console.Write("Ingrese su opción: ");


    if (!int.TryParse(Console.ReadLine(), out opcion) || ( opcion > 5 || opcion < 1 ))
    {
        Console.WriteLine("Entrada no válida.");

        continue;
    }
    
    Console.Write("Ingrese el primer número: ");
    var numero1 = LeerNumero();

    Console.Write("Ingrese el segundo número: ");
    var numero2 = LeerNumero();

    switch (opcion)
    {
        case 1:
            Console.WriteLine($"Resultado: {Sumar(numero1, numero2)}");
            break;
        case 2:
            Console.WriteLine($"Resultado: {Restar(numero1, numero2)}");
            break;
        case 3:
            Console.WriteLine($"Resultado: {Multiplicar(numero1, numero2)}");
            break;
        case 4:
            Console.WriteLine($"Resultado: {Dividir(numero1, numero2)}");
            break;
        case 5:
            Console.WriteLine("Saliendo de la calculadora.");
            break;
        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
}

