// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//и проверяет, является ли этот день выходным

Console.Write("Введите число > ");
int numDay = Convert.ToInt32(Console.ReadLine());

if (numDay >= 1 && numDay <= 7)
{
    if (numDay >= 1 && numDay <= 5)
    {
        System.Console.WriteLine("Нет");
    }
    else
    {
        System.Console.WriteLine("Да");
    }
}
else
{
    System.Console.WriteLine("Число не соответствует дню недели");
}