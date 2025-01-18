public class Problem1
{
    public static void Main(string[] args)
    {
        int[] a1 = { 1, 3 };
        int[] a2 = { 2, 4 };
        double result = MedianOfTwoSortedArray(a1, a2);
        Console.WriteLine("The median of 2 given arrays is: ");
        Console.WriteLine(result);
    }

    static double MedianOfTwoSortedArray(int[] arr1, int[] arr2)
    {
        return (Math.Max(arr1[arr1.Length - 1], arr2[arr2.Length - 1]) + Math.Min(arr1[0], arr2[0])) / 2.0;
    }
}