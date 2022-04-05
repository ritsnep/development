using System;
public class MethodTeacher
{

    static void Main3()
    {
        MethodTeacher methodTeacher = new MethodTeacher();
        double sum = methodTeacher.Sum(256.56, 565.1);
        int sumeven = methodTeacher.SumEven(2, 3, 4);
        int sumeven1 = methodTeacher.SumEven(6, 5, 3, 4, 5, 36, 15);
        Console.WriteLine($"Sum Is {sum}");
        Console.WriteLine($"Sum Is {sumeven}");
        Console.WriteLine($"Sum Is {sumeven1}");
    }

    //simple with 2 args and a return type
    public double Sum(double firstNum, double secondNum)
    {
        return firstNum + secondNum;
    }


    public int SumEven(params int[] nums)

    {

        int sum = 0;
        foreach (int num in nums)
        {
            if (num % 2 == 0)

                sum = sum + num;
        }
        return sum;

    }

    //variable num of agrs

    public double Sum(params double[] numbers)
    {
        double sum = 0;
        foreach (double num in numbers)
        {
            sum = sum + num;
        }
        return sum;
    }

    // Returning multiple values -using tuples
    // Ex: Find Min and max from set of numbers

    internal (int, int) FindMinMax(int[] numbers)
    {
        int min = numbers[0];
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num < min)
                min = num;
            if (num > max)
                max = num;
        }
        return (min, max);

    }

    internal void PrintCustomerDetails(string name, byte age, string address)
    {
        Console.WriteLine($"Name: {name}[{age}],Address: {address}");
    }

//Generic Methods
     public void Sum<type>(type firstNum, type secondNum)
    {
    }

}
public class MethodTester
{
    static void Main()
    {
        MethodTeacher methodTeacher = new MethodTeacher();
        int[] numbers = { 32, 56, 23, 1, 3, 26, 1, 32, 32 };
        (int Min, int Max) result = methodTeacher.FindMinMax(numbers);

        Console.WriteLine($"Minimum: {result.Min}, Maximum: {result.Max}");
        methodTeacher.PrintCustomerDetails(age:25,address:"BRJ",name:"Rits");
        methodTeacher.Sum<float>(336.56f,4564.263f);
    }

}