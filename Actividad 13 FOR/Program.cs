Console.WriteLine("Ingrese un número segun la opción que necesite");
Console.WriteLine("1. Mostrar los números del 1 al 10.\r\n2. Mostrar los números del 1 al 20 en la misma línea separados por espacio.\r\n3. Mostrar los números del 10 al 1 en orden descendente.\r\n4. Mostrar únicamente los números pares del 1 al 20.\r\n5. Mostrar únicamente los números impares del 1 al 20.");
Console.WriteLine("6. Mostrar la palabra “Hola” 5 veces.\r\n7. Mostrar los números del 1 al 10 junto con su cuadrado. Ejemplo: 3 → 9\r\n8. Mostrar los números del 1 al 50 que sean múltiplos de 5.\r\n9. Mostrar la suma de los números del 1 al 10.\r\n10. Mostrar la suma de los números del 1 al 100.");
Console.WriteLine("11. Pedir un número al usuario y mostrar su tabla de multiplicar del 1 al 10.\r\n12. Pedir un número y mostrar los números desde 1 hasta ese número.\r\n13. Pedir un número y mostrar los números desde ese número hasta 1.\r\n14. Pedir 3 números y mostrar la suma total.\r\n15. Pedir 5 números y mostrar el promedio.");
Console.WriteLine("16. Pedir 5 números y mostrar cuántos son mayores que 10.\r\n17. Pedir 5 números y mostrar cuántos son pares.\r\n18. Pedir 5 números y mostrar el número mayor ingresado.\r\n19. Pedir 5 números y mostrar el número menor ingresado.\r\n20. Pedir una cantidad N de números e indicar cuántos son positivos.");
Console.WriteLine("21. Pedir una cantidad N de números e indicar cuántos son negativos.\r\n22. Pedir N ventas e indicar el total vendido.\r\n23. Pedir N notas y mostrar el promedio final.\r\n24. Pedir N notas y mostrar si el promedio es aprobado (>=61) o reprobado.\r\n25. Pedir un número y dibujar una escalera con asteriscos.\r\n");
int opcion = int.Parse(Console.ReadLine());
switch (opcion)
{
    case 1:
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
        break;
    case 2:
        for (int i = 1; i <= 20; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        break;
    case 3:
        for (int i = 10; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
        break;
    case 4:
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
        break;
    case 5:
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
        break;
    case 6:
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Hola");
        }
        break;
    case 7:
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{i} → {i * i}");
        }
        break;
    case 8:
        for (int i = 1; i <= 50; i++)
        {
            if (i % 5 == 0)
            {
                Console.WriteLine(i);
            }
        }
        break;
    case 9:
        int suma = 0;
        for (int i = 1; i <= 10; i++)
        {
            suma += i;
        }
        Console.WriteLine($"La suma de los números del 1 al 10 es: {suma}");
        break;
    case 10:
        int suma1a100 = 0;
        for (int i = 1; i <= 100; i++)
        {
            suma1a100 += i;
        }
        Console.WriteLine($"La suma de los números del 1 al 100 es: {suma1a100}");
        break;
    case 11:
        Console.WriteLine("Ingrese un número ");
        int numero = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
        break;
    case 12:
        Console.WriteLine("Ingrese un número");
        int limite = int.Parse(Console.ReadLine());
        for (int i = 1; i <= limite; i++)
        {
            Console.WriteLine(i);
        }
        break;
    case 13:
        Console.WriteLine("Ingrese un  número mayor a 1");
        int limite2 = int.Parse(Console.ReadLine());
        for (int i = limite2; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
        break;
    case 14:
        int suma1 = 0;
        int resu14 = 0;
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"Ingrese el número {i}:");
            int num = int.Parse(Console.ReadLine());
            resu14 += num;
        }
        Console.WriteLine($"el resultados es {resu14}");
        break;   
    case 15:
        int resu15 = 0;
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Ingrese el número {i}:");
            int num = int.Parse(Console.ReadLine());
            resu15 += num;
        }
        Console.WriteLine("El promedio es"+(resu15/5));
        break;
}