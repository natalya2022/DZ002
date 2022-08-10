// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

Console.Write("Введите число > ");
int num1 = Convert.ToInt32(Console.ReadLine());          // Вводим значение

if (num1 < 0){
    num1 = -num1;                        // Можно вводить отрицательное число           
} 
if (99 < num1)
{
    while (num1 >= 1000)
    {
        num1 = num1 / 10;
    }
    int num2 = num1 % 10;
    System.Console.WriteLine($"Третья цифра числа равна {num2}");  // Вывод результата
}
else
{
    System.Console.WriteLine($"Третьей цифры у числа нет");         // Вывод результата
}