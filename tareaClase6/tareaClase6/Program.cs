// Se genera un numero entero aleatorio de 1 a 20
Console.WriteLine("Bienvenido, adivine en que numero del 1 al 20 estoy pensando!");
int secretNum = new Random(DateTime.Now.Millisecond).Next(1, 21);
// Variable donde se guardara la cantidad de veces iteradas
int triesCount = 0;

/* 
    Variable donde se guardara eventualmente el numero ingresado por el usuario
    se inicializa fuera del rango del secretNum para que pueda entrar al bucle
*/ 
int userNum = -1;

while (userNum != secretNum)
{
    // Sumamos una vuelta a la variable
    triesCount++;
    // Pedimos ingresar un valor
    Console.WriteLine("ingrese su numero: ");
    // Se guarda el nuevo valor introducido por el usuario en la variable userNum
    userNum = Convert.ToInt32(Console.ReadLine());

    // Aplicamos condicionales para indicar que el numero del usuario es mayor o menor que el numero generado
    if (userNum > secretNum)
    {
        Console.WriteLine("El numero ingresado es incorrecto. (Es mayor al numero que estoy pensando). Intentelo nuevamente!");
    }
    else if (userNum < secretNum)
    {
        Console.WriteLine("El numero ingresado es incorrecto. (Es menor al numero que estoy pensando). Intentelo nuevamente!");
    }
}
// Sale del vucle cuando el numero generado y el ingresado por el usuario dejan de representar una desigualdad

// Finalmente se notifica el numero acertado y la cantidad de veces que se itero
Console.WriteLine($"Felicitaciones, has adivinado el número secreto que era:  {secretNum}");
Console.WriteLine($"Lo has logrado en {triesCount} intentos!!");