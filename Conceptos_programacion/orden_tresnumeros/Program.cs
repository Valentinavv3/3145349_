int contador = 1;
int[] numeros = new int[3];

while (contador <= 3)
{
    Console.WriteLine($"Ingrese número {contador}: ");
    numeros[contador - 1] = int.Parse(Console.ReadLine());
    contador++;
}

int mayor = numeros[0];
int menor = numeros[0];

if (numeros[1] > mayor) mayor = numeros[1];
if (numeros[2] > mayor) mayor = numeros[2];

if (numeros[1] < menor) menor = numeros[1];
if (numeros[2] < menor) menor = numeros[2];

int medio = numeros[0] + numeros[1] + numeros[2] - mayor - menor;

Console.WriteLine("El número mayor es: " + mayor);
Console.WriteLine("El número del medio es: " + medio);
Console.WriteLine("El número menor es: " + menor);