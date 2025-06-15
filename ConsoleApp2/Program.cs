// See https://aka.ms/new-console-template for more information

int numero1;
int numero2;

Console.WriteLine("Hello, World!");
Console.WriteLine("inserisci il primo numero");
numero1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("inserisci il secondo numero");
numero2 = Convert.ToInt32(Console.ReadLine());
if (numero1 >= numero2)
{
    Console.WriteLine("il numero maggiore è "+ numero1);
    
}
else
{
    Console.WriteLine("il numero maggiore e "+ numero2);
}