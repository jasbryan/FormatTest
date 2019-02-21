using System;

namespace AbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            LifeTimeMember myLTM = new LifeTimeMember("Alice", "elm street", "777-333-2222", 2342);

            YearlyMember myYM = new YearlyMember("Joe", "birch street", "333-444-6767", 1213);

            Console.WriteLine(myLTM.ToString());

            Console.WriteLine(myYM.ToString());

            PrintMemberInformation(myLTM);

            PrintMemberInformation(myYM);
                       
            Console.WriteLine("Hello World!");
        }

        private static void PrintMemberInformation(Member daMember)
        {
            Console.WriteLine($"Here is a member:{daMember}");
        }
    }
}
