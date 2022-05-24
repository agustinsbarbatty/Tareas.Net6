/*
1) Crear una matriz de dos dimensiones de tipo int llamada numeros,
2) Determinar el tamaño de cada dimansion (fila, columnas) mediante valores ingresados por pantalla
3) Declarar un vector de tipo double llamado promedios
4) Recorrer la matriz para su carga con elementos de tipo int
5) Recorrer la matriz para mostrar cada valor de la matriz
6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios
7) Mostrar los promedios recorriendo el vector promedios 
 */

Console.WriteLine("ingrese la cantidad de alumnos a evaluar: ");
int alumnos = int.Parse(Console.ReadLine());

Console.WriteLine("ingrese la cantidad de notas a evaluar: ");
int notas = int.Parse(Console.ReadLine());

int sumaNotas = 0;

int[,] numeros = new int[alumnos, notas];

double[] promedios = new double[alumnos];

//int lengthI = numeros.GetUpperBound(0) + 1;  ==>  ultimo indice del indice pasado como argumento
//int lengthJ = numeros.GetUpperBound(1) + 1;  ==>  ultimo indice del indice pasado como argumento


for (int i = 0; i < alumnos; i++)
{
    Console.WriteLine($"Ingrese las notas del alumno Nº {i + 1}: ");

    for (int j = 0; j < notas; j++)
    {
        Console.WriteLine($"Cargue la nota Nº {j + 1}: ");
        numeros[i, j] = int.Parse(Console.ReadLine());

        sumaNotas += numeros[i, j];
    }
    promedios[i] = sumaNotas / notas;
    sumaNotas = 0;
}

Console.Clear();

for (int i = 0; i < alumnos; i++)
{
    Console.WriteLine($"Las notas del alumno Nº {i + 1} son: ");

    for (int j = 0; j < notas; j++)
    {
        Console.WriteLine($"La nota Nº {j + 1}: {numeros[i, j]}");
        
    }
}

Console.WriteLine("Los promedios son: ");

for (int i = 0; i < promedios.Length; i++)
{
    Console.WriteLine($"Promedio del alumno Nº {i + 1} es: {promedios[i]}");
}