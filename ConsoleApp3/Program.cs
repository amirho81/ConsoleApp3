using System;
class TriangularSequence
{
    static void Main()
    {
        Console.Write("یک عدد وارد نمایید :");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(triangularSequence(n));
    }
    static string triangularSequence (int n)
    {
        string sequence = " ";
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
            sequence += sum + ", ";
        }
        sequence = sequence.Remove(sequence.Length - 2);
        return sequence;
    }
}
//امیرحسین جورابچی
//6.دنباله مثلثی