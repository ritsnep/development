using System;

class IterationStatement
{
    static void Main324()
    {
        IterationStatement iterationStatement = new IterationStatement();
        iterationStatement.LearnWhileLoopSTR();
    }

    void LearnForLoop()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("iam fine");
        }

        int[] numbers = { 34, 36, 3, 5, 78 };
        foreach (int x in numbers)
        {
            if (x % 2 == 0)
            {

                Console.WriteLine($"{x} is even");

            }
            else
            {
                Console.WriteLine($"{x} is odd");
            }
        }


    }
    void LearnWhileLoop()
    {
        int i = 0;
        while (i < 10)
        {
            Console.WriteLine("iam fine");
            i++;
        }
    }
    void LearnWhileLoopSTR()
    {
        char confirm = 'y';
        while (confirm == 'y')
        {
            Console.WriteLine("iam fine");
            Console.WriteLine("Do You need to print one more time?");
            confirm = Console.ReadKey().KeyChar;
        }

               do
        {
            Console.WriteLine("iam fine");
            Console.WriteLine("Do You need to print one more time?");
            confirm = Console.ReadKey().KeyChar;
        }  while (confirm == 'y');
    }
}