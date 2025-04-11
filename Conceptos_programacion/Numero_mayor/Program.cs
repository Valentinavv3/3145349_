int contador = 1;
int numero;
int mayor = int.MinValue;

while (contador <= 3)
{
    Console.WriteLine($"Ingresa un numero{contador} : ");
    numero = int.Parse(Console.ReadLine());
    if (numero > mayor)
    {
        mayor = numero;
    }
    contador++;
}
Console.WriteLine($"El numero mayor es: {mayor}");

