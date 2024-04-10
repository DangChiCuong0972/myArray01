internal class Program
{
    private static void Main(string[] args)
    {
         int[] aray01 = new int[8];
    for (int i = 0; i < aray01.Length ; i++)
    {
        aray01[i] = i;
    }
    int sum03 = 0;
    for (int i = 0; i < aray01.Length ; i++)
    {
       if (i < aray01.Length - 1)
       Console.Write(aray01[i] + ",");
       else Console.Write(aray01[i]);

       sum03 += aray01[i];
    }
    Console.WriteLine(" ");
    Console.WriteLine("gia tri tong cua mang :" + sum03);

    }
}