Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());

CubeTable(N);

void CubeTable(int N)
{
   int[] arr = new int[N + 1];
   for (int i = 1; i < arr.Length; i++)
   {
      arr[i] = i;
      Console.WriteLine(Math.Pow(i, 3));
   }
}
