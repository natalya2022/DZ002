// Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа 
// Решение без введения дополнительной переменой

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобразует строку в целое число
    return result;                          // Возвращает результат
}

int num1 = Prompt("Введите трехзначное число > ");          // Вводим значение

if (num1 < 0){
    num1 = -num1;                            // Можно вводить и отрицательные числа
} 
if (99 < num1 && num1 < 1000)
{
    System.Console.WriteLine($"Вторая цифра числа равна {num1 / 10 % 10}");  // Вывод результата
}
else
{
    System.Console.WriteLine($"Число не трехзначное");
}
