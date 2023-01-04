using System;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
class Program
{

    public static void Main(string[] args)
    {


        int a = 10;
        int b = 39;
        int c;


        c = a + b;
        int d = a - b;
        Console.WriteLine("The sum of two number is: {0},{1}", c, d);



        // Swapping of two number
        Console.WriteLine("swapping of two number");
        Console.WriteLine("\nenter the first number: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nenter the second number: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        int temp = n1;
        n1 = n2;
        n2 = temp;
        Console.WriteLine("\nafter swap:");
        Console.WriteLine("\nfirst number:" + n1);
        Console.WriteLine("\nsecond number:" + n2);


        //Multiplication of two number
        Console.WriteLine("Multiplication of two number");
        Console.Write("enter first number:");
        int x1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("enter second number:");
        int x2 = Convert.ToInt32(Console.ReadLine());
        int mul = (x1 * x2);
        Console.WriteLine("Multiplication is:" + mul);


        //average of the three numbers
        Console.WriteLine("avg of three number");
        Console.WriteLine("enter the 1st number:");
        double p = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("enter the 2nd number:");
        double q = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("enter the 3rd number:");
        double r = Convert.ToDouble(Console.ReadLine());
        double avg = (p + q + r) / 3;
        Console.WriteLine("avg is:" + avg);

        Console.WriteLine("string operation");
        string s;
        Console.WriteLine("input the string:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
         s = Console.ReadLine();
        if (s!=null && s.Length >= 1)
        {
            string s1 = s.Substring(0, 1);
            Console.WriteLine(s1 + s + s1);
            Console.WriteLine("string to uppercase");
            Console.WriteLine(s.ToUpper());
        }

        Console.WriteLine("checking the number is positive and negitive both ");
        Console.WriteLine("enter the first num:");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the second num:");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine((m > 0 && n < 0) || (m < 0 && n > 0));

        Console.WriteLine("absolute difference of two number");
        Console.WriteLine(Diff(5,7));
         static int Diff(int a, int b)
        {
            if(a>b)
            {
                return (a-b);
            }
            return(b-a);
        }


        //longest word in string
        Console.WriteLine("longest word in string");
        Console.WriteLine("input the string:");
        string str = Console.ReadLine();
 #pragma warning disable CS8602
        string[] words = str.Split(new[] { " " }, StringSplitOptions.None);
#pragma warning disable CS0219
        string word = "";
        int ctr = 0;
        foreach (String i in words)
        {
            if(i.Length >= ctr)
            {

                word = i;
                ctr = i.Length;
            }
        }
        Console.WriteLine("the longest word :" + word);



        Console.WriteLine("\nodd number between 1 to 100");
        for(int j = 1; j < (99 + 1); j++)
        {
            if(j%2 !=0)
            {
                Console.Write(j+" ");
            }
        }

        Console.WriteLine("\nsum of prime number between 1 to 500");
        int sum = 0;
        for(int i = 1; i < 500; i++)
        {
            if(isPrime(i))
            {
                sum = sum + i;
            }
        }
        Console.WriteLine("sum of prime number:" + sum);

        Console.WriteLine("Sum of first 500 prime number:");
        int sum1 = 0;
        int cnt = 0;
        int no = 2;
        while(cnt < 500)
        {
            if (isPrime(n))
            {
                sum1= sum1 + n;
                cnt++;
            }
            no++;
        }
        Console.WriteLine("sum of first 500 prime number:" + sum1);



        static bool isPrime(int i)
        {

            int num = (int)Math.Sqrt(i);
            if(i==1) { return false; }
            if(i==2) { return true;}
            for(int j=2;j<num; j++)
            {
                if(i%j== 0) { return false; }
            }
            return true;
        }







    }
}
