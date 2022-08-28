//Задача 10
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Введите трёхзначное число: ");
// int EnterNumber = Convert.ToInt32(Console.ReadLine());
// string strNumber = Convert.ToString(EnterNumber);
// Console.WriteLine("Вторая цифра введенного числа = "+strNumber[1]);

//----------------------------------------------------------------
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Write("Введите число: ");
// int EnterNumber = Convert.ToInt32(Console.ReadLine());
// string strNumber = Convert.ToString(EnterNumber);
// if (strNumber.Length > 2)
// {
//     Console.WriteLine("Третья цифра введенного числа = "+strNumber[2]);
// } 
// else     
//     Console.WriteLine ("третьей цифры нет");


//----------------------------------------------------------------
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру от 1 до 7, обозначающую день недели: ");
int dayNum = Convert.ToInt32(Console.ReadLine());

void NumberOfTheDayOfTheWeek (int dayNum) {
    
  if (dayNum == 6 || dayNum == 7) {
  Console.WriteLine("Выходной день");
  }
  else if (dayNum < 1 || dayNum > 7) {
    Console.WriteLine("Ошибка. Введите цифру от 1 до 7");
  }
  else Console.WriteLine("Будний день");
}
NumberOfTheDayOfTheWeek(dayNum);