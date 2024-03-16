using System.Diagnostics.CodeAnalysis;
static void ejemplo()
{
    int[] calificaciones;
    int suma1 = 0;
    int promedio1 = 0;
    int suma2 = 0;

    calificaciones = new int[] { 85, 92, 77, 68, 94, 20, 10, 52, 99, 35 };
    foreach (int calificacion in calificaciones)
    {
        suma1 += calificacion;
    }
    int longitudarreglo = calificaciones.Length;

    promedio1 = suma1 / calificaciones.Length;

    foreach (int cal in calificaciones)
    {
        Console.WriteLine("las calificaciones son: " + cal);
    }
    Console.WriteLine("El promedio de las calificaciones es: " + promedio1);

    for (int i = 0; i < longitudarreglo; i++)
    {
        suma2 += calificaciones[i];
    }
    int promedio2 = suma2 / longitudarreglo;

    Console.WriteLine("La suma de las calificaciones usando un for es: " + suma2);
    Console.WriteLine("El promedio de las calificaciones usando un for es: " + promedio2);

    Array.Sort(calificaciones);
    foreach (int cal in calificaciones)
    {
        Console.WriteLine("las calificaciones ordenadas son: " + cal);
    }


}




static void despliegue(int[] arreglo)
{
    foreach (int item in arreglo)
    {
        Console.WriteLine(item);
    }
}

    static void ejemplo10()
    {
        int[] elementos = new int[] { 50, 20, 80, 90, 60 };
        Console.WriteLine("Original: ");
        despliegue(elementos);
        Console.WriteLine("Ordenados: ");
        Array.Sort(elementos);
        despliegue(elementos);
    Console.WriteLine("EN reversa mami");
        Array.Reverse(elementos);
        despliegue(elementos);

        int indice = Array.IndexOf(elementos, 80);
        Console.WriteLine("El indice es: "+ indice);


    int primernumeromayor=
    }

    ejemplo10();


