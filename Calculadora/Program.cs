using Calculadora;

Console.WriteLine("Mi calculadora");

var calcular = new CalculadoraApp();

// declaración de variables
int a = 5;
int b = 10;

// Sumar
Console.WriteLine("SUMA");
var suma = calcular.Sumar(a, b);
Console.WriteLine($"La suma entre {a} y {b} es: {suma}\n");

// Restar
Console.WriteLine("RESTA");
var resta = calcular.Restar(a, b);
Console.WriteLine($"La resta entre {a} y {b} es: {resta}\n");

// Multiplicar
Console.WriteLine("MULTIPLICACIÓN");
var multiplicacion = calcular.Multiplicar(a, b);
Console.WriteLine($"La multiplicación entre {a} y {b} es: {multiplicacion}\n");

// Dividir
Console.WriteLine("DIVISIÓN");
var division = calcular.Dividir(a, b);
Console.WriteLine($"La división entre {a} y {b} es: {division}\n");

// Calcular porcentaje
Console.WriteLine("PORCENTAJE");
var porcentaje = calcular.SacarPorcentaje(a, b);
Console.WriteLine($"{a} es el {porcentaje}% de {b}\n");
