using System;
using System.Threading;

/*class Example
{
    static char GetRandomChar()
    {
        string symbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ123456789!@#$%^&*(/)><|:}{[]";
        Random r = new Random();
        var index = r.Next(symbols.Length);
        return symbols[index];
    }

    static void ShowChar()
    {
        Console.WriteLine(GetRandomChar());
    }
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();


        Random x = new Random();

        while (true)
        {
            int valueX = x.Next(0, 237);
            int valueY = x.Next(0, 100);

            Console.SetCursorPosition(valueX, valueY);
            Console.WriteLine(GetRandomChar());
        }
    }
}*/
namespace cppBox
{


    class Danil
    {
        public string fullName;
        public int age;
        public const string eyeCol = "brown";
        public const string hairCol = "fair-haired";
        public string hobbies = "sports, books, music";


        public Danil(string fullName, int age)
        {
            this.fullName = fullName;
            this.age = age;
        }
        public string GetFullName()
        {
            return fullName;
        }
        public int GetAge()
        {
            return age;
        }
        public string GetEye()
        {
            return eyeCol;
        }
        public string GetHair()
        {
            return hairCol;
        }
        public string GetHobbies()
        {
            return hobbies;
        }

        public void awakening()
        {
            Console.WriteLine("I wake up and get out of bed");
        }
        public void breakfast()
        {
            Console.WriteLine("Having breakfast");
        }

        public void dayPlanning()
        {
            Console.WriteLine("Planning my day");
        }

        public void time()
        {
            Console.WriteLine("Spend my time doing something or with someone");
        }

        public void dinner()
        {
            Console.WriteLine("Having supper");
        }

        public void sleep()
        {
            Console.WriteLine("I go to bed");
        }

    }

    class Programm
    {
        static void Main(string[] args)
        {
            Danil danil = new Danil("Gafiullin Danil", 16);
            danil.awakening();
        }
    }
}