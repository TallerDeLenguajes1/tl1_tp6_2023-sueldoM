// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;
a=10;
b=a;

Console.WriteLine("Valor de a: {0}",+a);
Console.WriteLine("Valor de b: {0}",+b);

float floatNum1=0;
bool anda = false;
string? numString = "";
while (!anda)
{
    Console.WriteLine("Ingrese un numero valido: ");
    numString = Console.ReadLine();
    anda = float.TryParse(numString, out floatNum1);
    if (!anda)
    {
        Console.WriteLine(numString + " no es un numero valido.");
    }
}

int intNum = (int)floatNum1;
int reversedNum = ReverseNumber(intNum);
Console.WriteLine("Número invertido: " + reversedNum);

// Método para invertir el número
int ReverseNumber(int number)
{
    int reversedNumber = 0;
    while (number != 0)
    {
        int digit = number % 10;
        reversedNumber = reversedNumber * 10 + digit;
        number /= 10;
    }
    return reversedNumber;
}
