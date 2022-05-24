/*
1) Pida 10 números al usuario.
2) Obtener la suma de todos los números ingresados.
3) Obtener cual es el mayor de todos los números.
4) Obtener cual es el menor de todos los números.
5) Obtener el promedio de todos los números.
6) Mostrar todos los números ingresados por pantalla.
7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5.
*/
int[] arr = new int[10];

int totalNum = 0;

Console.Clear();
Console.WriteLine("ingrese 10 numeros: ");

for (int i = 0; arr.Length > i; i++) 
{
    Console.WriteLine($"valor {i + 1}:");
    arr[i] = int.Parse(Console.ReadLine());

    totalNum = totalNum + arr[i];
}

int mayorNum = arr[0];
int menorNum = arr[0];
int promedioNum = totalNum / arr.Length;

for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] > mayorNum)
    {
        mayorNum = arr[i];
    }
    if (arr[i] < menorNum)
    {
        menorNum = arr[i];
    }
}

Console.Clear();

Console.WriteLine("los numeros ingresados son: ");

for (int i = 0; i < arr.Length; i++)
{
    int elemento = arr[i];
    Console.Write(" - ");
    Console.Write(elemento);
}
Console.WriteLine();

Console.WriteLine($"el mayor numero es: {mayorNum}");
Console.WriteLine($"el menor numero es: {menorNum}");
Console.WriteLine($"la suma de los numeros es: {totalNum}");
Console.WriteLine($"el promedio es: {promedioNum}");