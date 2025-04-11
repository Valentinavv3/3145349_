int año = 0;
bool valido = false;

while (!valido)
{
    try
    {
        Console.Write("Ingrese año: ");
        año = int.Parse(Console.ReadLine());
        valido = true;
    }
    catch
    {
        Console.WriteLine("Por favor, ingrese un año válido.");
    }
}

// Verificar si es bisiesto
if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
{
    Console.WriteLine($"El año: {año}, sí es bisiesto");
}
else
{
    Console.WriteLine($"El año: {año}, no es bisiesto");
}