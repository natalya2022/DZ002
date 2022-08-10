// Напишите программу, которая выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа.

int num1 = new Random().Next(100, 999);         //генерируем случайное число
System.Console.WriteLine (num1);

int num2 = 10 * ( num1 / 100 )  + ( num1 % 10 ); 
System.Console.WriteLine(num2);                 // Вывод результата

