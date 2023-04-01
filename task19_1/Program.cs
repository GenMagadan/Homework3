Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine(Definition(number));

string Definition(int number)
{
   if (number > 9999 && number < 99999)
   {
      if (number / 10000 == number % 10 || (number % 10000) / 1000 == (number % 100) / 10)
      {
         return $"Число {number} является палидромом";
      }
      return $"Число {number} не является палидромом";
   }
   return $"Число {number} не является пятизначным числом";
}

