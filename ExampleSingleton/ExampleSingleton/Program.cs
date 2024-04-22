using System;

namespace ExampleSingleton
{
    public class Singleton
    {
        private static Singleton instance;

        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        public void PrintMessage()
        {
            Console.WriteLine("1 2 3");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Singleton singletonInstance = Singleton.GetInstance();

            singletonInstance.PrintMessage();

            Singleton anotherSingletonInstance = Singleton.GetInstance();

            if (singletonInstance == anotherSingletonInstance)
            {
                Console.WriteLine("Перевірка...");
            }
            else
            {
                Console.WriteLine("Помилка! Сталася помилка при отриманні Перевірки.");
            }
        }
    }
}
