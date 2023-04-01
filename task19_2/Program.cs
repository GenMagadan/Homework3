/*Актуально для слова, состоящего из разных символов. Для строки не подходит.*/

Console.Write("Введите слово: ");
string str = Console.ReadLine();
string newstr = str.ToUpper();

Console.WriteLine(Definition(newstr));

string Definition(string newstr)
{
   for (int i = 0; i < newstr.Length / 2; i++)
   {
      if (newstr[i] != newstr[newstr.Length - i - 1])
      {
         return "Не является палидромом";
      }
   }
   return "Является палидромом";
}

/* 45Ghjjhg54 - является палидромом */