using System;
namespace EnumsAndProperties
{
enum DayOfWeek
{
    sunday,
    monday,
    tuesday,
    wednesday,
    thursday, friday, saturday
}
internal class Demo
{
    public DayOfWeek DayOfWeek {get; set;}
    void PrintGreetings()
    {
        
        if (DayOfWeek==DayOfWeek.saturday)
        {
            Console.WriteLine("Its a Good Saturday");

        }
        else if(DayOfWeek==DayOfWeek.sunday)
        {
            Console.WriteLine("Its yet another weekend days");
        }
        else
        {
            Console.WriteLine("Its a Workdays");
        }
    }
}

}