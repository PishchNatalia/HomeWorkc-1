// Домашняя работа
//Задача 2

Console.Write("Imput a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

    if (num1>num2 & num1>num3)
{
    Console.WriteLine("Максимальное число num1");
}
    if (num2>num1 & num2>num3)
{
    Console.WriteLine("Максимальное число num2");
}
    else
    
   Console.WriteLine("Максимальное число num3");

    