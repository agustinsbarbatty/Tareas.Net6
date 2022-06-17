/*
 Crear una clase Billetera que tenga las siguientes propiedades públicas del tipo entero:

BilletesDe10
BilletesDe20
BilletesDe50
BilletesDe100
BilletesDe200
BilletesDe500
BilletesDe1000

Agregar un método que se llame Total del tipo decimal, y que devuelva el Importe Total en la billetera teniendo en cuenta la cantidad de billetes que se tenga de cada tipo.

Agregar un metodo que se llame Combinar, que reciba como parámetro otra billetera y que devuelva una nueva Billetera con la suma o combinacion del dinero de ambas billeteras.  
Una vez combinadas las 2 billeteras (y creada la tercera), las 2 primeras billeteras deberan quedar en cero. (Sin billetes)
 */

using tareaClase13.Clase;

Console.WriteLine(" Bienvenido a su billetera! ");

Console.WriteLine("Ingrese la cantidad de billetes que desea guardar de $10");
var getBilleteDe10 = Console.ReadLine();

Console.WriteLine("Ingrese la cantidad de billetes que desea guardar de $20");
var getBilleteDe20 = Console.ReadLine();

Console.WriteLine("Ingrese la cantidad de billetes que desea guardar de $50");
var getBilleteDe50 = Console.ReadLine();

Console.WriteLine("Ingrese la cantidad de billetes que desea guardar de $100");
var getBilleteDe100 = Console.ReadLine();

Console.WriteLine("Ingrese la cantidad de billetes que desea guardar de $200");
var getBilleteDe200 = Console.ReadLine();

Console.WriteLine("Ingrese la cantidad de billetes que desea guardar de $500");
var getBilleteDe500 = Console.ReadLine();

Console.WriteLine("Ingrese la cantidad de billetes que desea guardar de $1000");
var getBilleteDe1000 = Console.ReadLine();

var myBilletera = new Billetera()
{
    BilletesDe10 = int.Parse(getBilleteDe10),
    BilletesDe20 = int.Parse(getBilleteDe20),
    BilletesDe50 = int.Parse(getBilleteDe50),
    BilletesDe100 = int.Parse(getBilleteDe100),
    BilletesDe200 = int.Parse(getBilleteDe200),
    BilletesDe500 = int.Parse(getBilleteDe500),
    BilletesDe1000 = int.Parse(getBilleteDe1000)
};
Console.Clear();

Console.WriteLine($"El valor total de su billetera es de ${myBilletera.Total()}");

Console.WriteLine("Desea crear otra billetera? ");
Console.WriteLine("Presione |S| para si, o |N| para no :");

var myNewBilletera = new Billetera();
var respuesta = Console.ReadLine();

if (respuesta.ToLower() == "s")
{
    Console.WriteLine("Ingrese la cantidad de billetes que desea guardar de $10");
    var getNewBilleteDe10 = Console.ReadLine();

    Console.WriteLine("Ingrese la cantidad de billetes que desea guardar de $20");
    var getNewBilleteDe20 = Console.ReadLine();

    Console.WriteLine("Ingrese la cantidad de billetes que desea guardar de $50");
    var getNewBilleteDe50 = Console.ReadLine();

    Console.WriteLine("Ingrese la cantidad de billetes que desea guardar de $100");
    var getNewBilleteDe100 = Console.ReadLine();

    Console.WriteLine("Ingrese la cantidad de billetes que desea guardar de $200");
    var getNewBilleteDe200 = Console.ReadLine();

    Console.WriteLine("Ingrese la cantidad de billetes que desea guardar de $500");
    var getNewBilleteDe500 = Console.ReadLine();

    Console.WriteLine("Ingrese la cantidad de billetes que desea guardar de $1000");
    var getNewBilleteDe1000 = Console.ReadLine();


    myNewBilletera.BilletesDe10 = int.Parse(getNewBilleteDe10);
    myNewBilletera.BilletesDe20 = int.Parse(getNewBilleteDe20);
    myNewBilletera.BilletesDe50 = int.Parse(getNewBilleteDe50);
    myNewBilletera.BilletesDe100 = int.Parse(getNewBilleteDe100);
    myNewBilletera.BilletesDe200 = int.Parse(getNewBilleteDe200);
    myNewBilletera.BilletesDe500 = int.Parse(getNewBilleteDe500);
    myNewBilletera.BilletesDe1000 = int.Parse(getNewBilleteDe1000);

    Console.Clear();

    Console.WriteLine($"El valor total de su billetera es de ${myBilletera.Total()}");
    Console.WriteLine("");
    Console.WriteLine($"El valor total de su nueva billetera es de ${myNewBilletera.Total()}");
    Console.WriteLine("");

    Console.WriteLine("A continuacion se combinaran hambas billeteras en una sola: ");

    var myBilleteraCombinada = myBilletera.Combinar(myNewBilletera, myBilletera);

    Console.WriteLine("");
    Console.WriteLine($"El valor total de su primera billetera es de ${myBilletera.Total()}");

    Console.WriteLine("");
    Console.WriteLine($"El valor total de su segunda billetera es de ${myNewBilletera.Total()}");

    Console.WriteLine("");
    Console.WriteLine($"El valor total de su billetera combinada es de ${myBilleteraCombinada.Total()}");
}

if (respuesta.ToLower() == "n")
{
    Console.WriteLine("Fin del programa.");
}
