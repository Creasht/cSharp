// Задача 10: Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую
// Цифру этого числа.

System.Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

int index = number.ToString().Length;
System.Console.WriteLine(index);

if (index < 3 || index > 3)
{
    System.Console.WriteLine("Вы ввели не трехзначное число");
}
else 
{    int a = number % 100 / 10;
     System.Console.WriteLine($"Второе число {a}");
}


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей
// цифры нет.

System.Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

int index = number.ToString().Length;
System.Console.WriteLine(index);

if (index < 3 )
{
    System.Console.WriteLine("третьей цифры нет");
}
else 
{   
     int a = number / Convert.ToInt32(Math.Pow (10,index-3)) % 10;
     System.Console.WriteLine($"третья число {a}");
}



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

Console.Write("Введи цифру, дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

void day (int number) {
  if (number == 6 || number == 7) {
  Console.WriteLine("Этот день выходной");
  }
  else if (number < 1 || number > 7) {
    Console.WriteLine("Это не день недели");
  }
  else Console.WriteLine("Этот день не выходной");
}

day(number);
