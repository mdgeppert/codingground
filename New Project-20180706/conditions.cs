using System;

class Solution
{
    static void Main(string[] args)
    {
        Random r = new Random();
        int n = r.Next(1, 100);
        Console.WriteLine(n);

        if (n > 1 && n < 6 && n % 2 == 0)
        {
            Console.WriteLine("Not Wierd");
        }
        else
        {
            if (n > 6 && n < 21 && n % 2 == 0)
            {
                Console.WriteLine("Wierd");
            }
            else
            {
                if (n > 20 && n % 2 == 0)
                {
                    Console.WriteLine("Not Wierd");
                }
                else
                {
                    Console.WriteLine("Wierd");
                }
            }
            Console.ReadLine();

        }
    }
}