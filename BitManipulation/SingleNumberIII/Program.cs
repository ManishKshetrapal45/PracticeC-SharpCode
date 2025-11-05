//Single Number III
/*Problem Description
Given an array of positive integers A, two integers appear only once, and all the other integers appear twice.
Find the two integers that appear only once.
Note: Return the two numbers in ascending order.

Problem Constraints:
2 <= |A| <= 100000
1 <= A[i] <= 109

Input Format:
The first argument is an array of integers of size N.

Output Format:
Return an array of two integers that appear only once.

Example Input:
Input 1:
A = [1, 2, 3, 1, 2, 4]
Input 2:
A = [1, 2]

Example Output:
Output 1:
[3, 4]
Output 2:
[1, 2]

Example Explanation:
Explanation 1:
3 and 4 appear only once.
Explanation 2:
1 and 2 appear only once. */
namespace SingleNumberIII
{
  public class Program
  {
    public static void Main(string[] args)
    {
      List<int> A = [1, 2, 3, 1, 2, 4];
      var ans = Solve(A);
      foreach (var i in ans)
      {
        Console.WriteLine(i);
      }

    }

    public static List<int> Solve(List<int> A)
    {
      int xor = 0, bit = 0;
      List<int> B = new List<int>();
      for (int i = 0; i < A.Count(); i++)
      {
        xor = xor ^ A[i];
      }
      bit = CheckSetBit(xor);
      int arr1 = 0, arr2 = 0;
      for (int i = 0; i < A.Count(); i++)
      {
        if (((A[i] >> bit) & 1) == 1)
        {
          arr1 = arr1 ^ A[i];
        }
        else
        {
          arr2 = arr2 ^ A[i];
        }
      }
      if (arr1 < arr2)
      {
        B.Add(arr1);
        B.Add(arr2);
      }
      else
      {
        B.Add(arr2);
        B.Add(arr1);
      }
      return (B);
    }

    public static int CheckSetBit(int num)
    {
      int bit = 0;
      for (int i = 0; i < num; i++)
      {
        if (((num >> i) & 1) == 1)
        {
          bit = i;
          break;
        }
      }
      return (bit);
    }
  }
}