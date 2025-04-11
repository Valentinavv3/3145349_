int numero1 = 0;
int numero2 = 0;
bool valido = false;

while (!valido)
{
    try
    {
        Console.Write("Ingrese primer número: ");
        numero1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese segundo número: ");
        numero2 = int.Parse(Console.ReadLine());

        valido = true;
    }
    catch
    {
        Console.WriteLine("Por favor ingrese solo números válidos.");
    }
}


if (numero2 % numero1 == 0)
{
    Console.WriteLine($"El número: {numero2}, es múltiplo de: {numero1}");
}
else
{
    Console.WriteLine($"El número: {numero2}, no es múltiplo de: {numero1}");
}
