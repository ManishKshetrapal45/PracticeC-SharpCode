namespace LittlePonnyMaximumElement
{
  public class Program
  {
    public static void Main(string[] args)
    {
      List<int> A = new List<int> { 1, 4, 2 };
      int B = 3;
      Console.WriteLine(PonnyMaximumElement(A, B));
    }

    public static int PonnyMaximumElement(List<int> A, int B)
    {
      int flag = 0, count = 0;
      for (int i = 0; i < A.Count; i++)
      {
        if (A[i] > B)
        {
          count++;
        }
        if (A[i] == B)
        {
          flag = 1;
        }
      }
      if (flag == 1 && count != 0)
      {
        return count;
      }
      if (flag == 1 && count != 0)
      {
        return 0;
      }
      return -1;
    }
  }
}
