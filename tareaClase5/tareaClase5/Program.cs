
string respuesta = "S";


while (respuesta.ToLower() == "s")
{
    Console.Clear();
    Console.WriteLine("ingrese su nombre:");
    var name = Console.ReadLine();
    Console.WriteLine($"¡Hola {name}!");
    Console.WriteLine("para continuar precione (S), para finalizar presione (N).");
    respuesta = Console.ReadLine();
}
if (respuesta.ToLower() == "n")
{
    Console.WriteLine("Programa finalizado correctamente.");
}
else
{
    Console.WriteLine("Opcion no valida.");
}
