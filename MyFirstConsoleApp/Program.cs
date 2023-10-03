namespace MyFirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            challange1();
            challange3();
            challange4();
            challange5();  
        }

        static void challange1()
        {
            //asking user for name and saving it
            Console.WriteLine("Hello, what is your name?");
            string name = Console.ReadLine();

            //asking user for age and saving it
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            //calculating users age in 5 years
            int ageIn5Years = age + 5;

            //printing users name and age in 5 years to the console
            Console.WriteLine("Hello " + name + ", you will be " + ageIn5Years + " in 5 years");

            challange2If(age);
            challange2Else(age);

        }

        static void challange2If(int age)
        {
            if (age < 13)
            {
                Console.WriteLine("You are a child");
            }
            else if (age >= 13 & age <= 19)
            {
                Console.WriteLine("You are a teenager");
            }
            else
            {
                Console.WriteLine("You are an adult");
            }
        }

        static void challange2Else(int age)
        {
            switch (age)
            {
                case < 13:
                    Console.WriteLine("Child");
                    break;

                case < 20:
                    Console.WriteLine("Teenager");
                    break;

                default:
                    Console.WriteLine("Adult");
                    break;
            }
        }

        static void challange3()
        {
            for (int i = 65; i <= 122; i++)
            {
                if (i >= 91 & i <= 96)
                {

                }
                else
                {
                    int asciiPosition = i;
                    char alphabetUppercase = (char)asciiPosition;
                    Console.WriteLine(alphabetUppercase + " " + i);
                }
            }
        }

        static void challange4()
        {
            Console.WriteLine("Please enter any number: ");
            int fizzBuz = Convert.ToInt32(Console.ReadLine());

            for (int j = 1; j <= fizzBuz; j++)
            {
                if (j % 3 == 0 & j % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (j % 3 != 0 & j % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (j % 3 == 0 & j % 5 == 0)
                {
                    Console.WriteLine("FizzBuz");
                }
                else
                {
                    Console.WriteLine(j);
                }
            }
        }

        static void challange5()
        {
            int userInput;

            do
            {
                Console.WriteLine();

                Console.WriteLine("Please enter an option from below:");
                Console.WriteLine("1. Hello in French?");
                Console.WriteLine("2. Hello in Spanish?");
                Console.WriteLine("3. Hello in German?");
                Console.WriteLine("4. Hello in Irish?");
                Console.WriteLine("0. Exit application");

                userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == 1)
                {
                    Console.WriteLine("Bonjour");

                }
                else if (userInput == 2)
                {
                    Console.WriteLine("Hola");

                }
                else if (userInput == 3)
                {
                    Console.WriteLine("Guten Tag");

                }
                else if (userInput == 4)
                {
                    Console.WriteLine("Dia dhuit");

                }
                else if (userInput == 0)
                {
                    Console.WriteLine("Goodbye");

                }
                else if (userInput > 4)
                {
                    Console.WriteLine("Ivalid option please try again");
                }
            } while (userInput != 0);
        }
        
    }
}