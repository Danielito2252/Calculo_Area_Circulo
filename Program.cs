//PROGRAMA QUE CALCULA  AREA DE UN CIRCULO
Console.WriteLine("¡vamos a calcular el area de un circulo!");

//DEFINIMOS LAS VARIABLES
double radio;
double area;
string mensaje = "";
double PI = 3.1416;

    Console.WriteLine("Escriba o ingrese el valor del radio");
radio = Convert.ToDouble(Console.ReadLine());

 area = Math.PI * Math.Pow(radio, 2);

Console.WriteLine($"El radio del circulo es: {radio} y el area es: {area}");