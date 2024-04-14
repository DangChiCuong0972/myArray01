using System.Drawing;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
  
    private static void Main(string[] args)
    {
      Array01 ar01 = new Array01();
      ar01.P_Array();
      
      
    }
}

public class Array01
{
    public int[] Sheep = new int[4];

    public int[] tiger;

    public string[] name = {"Long", "Minh","Dan","Kim"};
    

     public void P_Array()
    {
        Console.WriteLine("Nhap kich thuoc mang");

        int size =0;
        do 
        {
             size = Convert.ToInt32(Console.ReadLine());
        }
        while (size > 8);

        int[] cloud = new int[size];

        Console.WriteLine("Nhap gia tri cua mang");
        for ( int i =0;i< cloud.Length;i++)
        {
            cloud[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("in gia tri mang ");
        for (int i =0; i< cloud.Length;i++)
        {
            Console.Write(cloud[i] + " , ");
        }
        
        int sum = 0;
        int max = 0;

        Console.WriteLine("Tinh tong va tim gia tri lon nha cua mang");
        for ( int j =0; j<cloud.Length; j++)
        {
            sum += cloud[j];
            if ( max < cloud[j])
            {
                max = cloud[j];
            }

        }

        Console.WriteLine(" tong cua mang la : " + sum);
        Console.WriteLine("gia tri lon nhat la :" + max);
        Console.WriteLine(cloud[3]);
        Console.WriteLine(cloud[4]);

    }
}

