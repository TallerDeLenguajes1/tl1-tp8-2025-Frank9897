using System;
using System.Reflection.Emit;
using esCalculadora;
using esOperacion;

Calculadora calc = new Calculadora();

do
{

    Console.WriteLine($"Resultado actual = {calc.Resultado}");
    Console.WriteLine("\nCalculadora\nOperaciones\n1. Sumar\n2. Restar\n3. Multiplicar\n4. Dividir\n5. Limpiar\n6. Mostrar Historial\nElegir opción:");
    int opc = int.Parse(Console.ReadLine());
    double num=0;
    if (opc <= 4)
    {
        Console.WriteLine("Ingrese un numero (terminar con 0):");
        num = double.Parse(Console.ReadLine());
    }
    switch (opc)
    {
        case 0:
            return; // salir del programa
        case 1:
            calc.Sumar(num);
            break;
        case 2:
            calc.Restar(num);
            break;
        case 3:
            calc.Multiplicar(num);
            break;
        case 4:
            calc.Dividir(num);
            break;
        case 5:
            calc.Limpiar();
            break;
        case 6:
            calc.MostrarHistorial();
            break;
        default:
            Console.WriteLine("Opción inválida.");
            break;
    }
} while (true);
