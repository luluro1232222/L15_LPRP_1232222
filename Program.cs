using System;

string option;

Console.WriteLine("¡Bienvenido! Por favor elija una opción");
Console.WriteLine("Presione 1: -----> Persona + edad");
Console.WriteLine("Presione 2: -----> Notas de programación por estudiante");
Console.WriteLine("Presione 3: -----> Salir");

option = Console.ReadLine();

switch (option)
{
    case "1":
        string[] nombre = new string[5];
        int[] años = new int[5];
        int menor = 10000;
        string menorP = "";
        int mayor = 1;
        string mayorP = "";
        int edad = 0;
        int e = 0;
        int suma1 = 0;
        double promedio1 = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Nombre de la persona");
            nombre[i] = Console.ReadLine();
            Console.WriteLine("Escriba la edad de la persona");
            años[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < 5; i++)
        {
            edad = años[i];
            if (menor > edad)
            {
                menor = años[i];
                e = i + 1;
                menorP = nombre[i];
            }
        }
        Console.WriteLine("La persona con menor edad " + menorP);
        for (int i = 0; i < 5; i++)
        {
            edad = años[i];
            if (mayor < edad)
            {
                mayor = años[i];
                e = i + 1;
                mayorP = nombre[i];
            }
        }
        Console.WriteLine("La persona con mayor edad " + mayorP);
        for (int i = 0; i<5; i++)
        {
            suma1 = suma1 + años[i];
        }
        promedio1 = suma1 / 5;
        Console.WriteLine("El promedio de las notas es: " + promedio1);
        break;

    case "2":
        string[] nombreApellido = new string[5];
        int[] notasEstudiantes = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Profesion: ");
            nombreApellido[i] = Console.ReadLine();
            Console.Write("Monto a pagar: ");
            notasEstudiantes[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < 5; i++)
        {
            if (notasEstudiantes[i] >= 71)
            {
                Console.WriteLine(nombreApellido[i] + " aprobó con " + notasEstudiantes[i]);
            }
            else
            {
                Console.WriteLine(nombreApellido[i] + " perdió con " + notasEstudiantes[i]);
            }
        }
        int notasas = 0;
        int Verdadero2 = 0;
        string notaMay = "";
        for (int i = 0; i < 5; i++)
        {
            if (notasas < notasEstudiantes[i])
            {
                notasas = notasEstudiantes[i];
                Verdadero2 = i + 1;
                notaMay = nombreApellido[i];

            }
        }
        Console.WriteLine("La nota más alta fue de " + notaMay);

        int notitas = 10000;
        int f = 0;
        string notaMen = "";
        for (int i = 0; i < 5; i++)
        {
            if (notitas > notasEstudiantes[i])
            {
                notitas = notasEstudiantes[i];
                f = i + 1;
                notaMen = nombreApellido[i];

            }
        }
        Console.WriteLine("La nota más baja fue de " + notaMen);

        double promedioOP2 = 0;
        double sumaOp2 = 0;
        for (int i = 0; i < 5; i++)
        {
            sumaOp2 = sumaOp2 + notasEstudiantes[i];
        }

        promedioOP2 = sumaOp2 / 5;
        Console.WriteLine("El promedio de las notas es " + promedioOP2);
        break;

    case "3":
        Console.WriteLine("Gracias por visitarnos!");
        Environment.Exit(0);
        break;
    default:
        Console.WriteLine("Ups!");
        break;
}
