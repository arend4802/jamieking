using System;

namespace jamieking
{
    class Program
    {
        static void Main()
        {
            HelloWorld();
            Variables();
            whileLoop();
            forLoop();
        }

        public static void HelloWorld()
        {
            Console.WriteLine("Hello world");
        }

        public static void Variables()
        {
            String myString = "jamieking";
            int age = 30;
            double myGpa = 3.99999;
            bool amTired = false;
            Console.WriteLine(myString);
            Console.WriteLine(age);

        }
        public static void whileLoop()
        {
            int i = 1;
            while (i <= 20)
            {
                Console.WriteLine(i);
                i = i + 1;
            }
            Console.WriteLine("Done");

        }
        public static void forLoop()
        {
            for (int i = 1; i <= 20; i = i + 1) //or option 2//  // for (int i =1; i <= 20; i++)// 
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Done");
        }


    }
}
