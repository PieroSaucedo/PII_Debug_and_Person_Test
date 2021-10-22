using System;

namespace UnitTestAndDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person("John Doe", "1.234.567-8", "10/03/1994");
            Person jane = new Person("Jane Doe", "8.765.432-1", "10/03/1994");
            john.IntroduceYourself();
            jane.IntroduceYourself();
        }
    }
}
