Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());

CubeTable(N);

void CubeTable(int N)
{
   for (int i = 1; i <= N; i++)
   {
      Console.WriteLine(Math.Pow(i, 3));
   }
}
