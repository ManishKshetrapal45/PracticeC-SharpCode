namespace SeparateOddEven
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Enter length of an array");
      int len = int.Parse(Console.ReadLine());
      int[] A = new int[len];
      Console.WriteLine("Enter array elements");
      for (int j = 0; j < len; j++)
      {
        A[j] = int.Parse(Console.ReadLine());
      }
      Console.WriteLine("Enter Valuse of B");
      var B = int.Parse(Console.ReadLine());
      Console.WriteLine(FindGoodPair(A, B));

    }

    public static int FindGoodPair(int[] A, int B)
    {
      for (int i = 0; i < A.Length; i++)
      {
        for (int j = 0; j < A.Length; j++)
        {
          if (i == j) continue;
          if (A[i] + A[j] == B) return 1;
        }
      }
      return 0;
    }
  }
}
