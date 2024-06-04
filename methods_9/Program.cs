namespace methods_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Menu();  
        }
        //End of main
        //Start of menu
        static void Menu()
        {
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Print Numbers");
                Console.WriteLine("2. Perform Algebra");
                Console.WriteLine("3. Work with Names");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice: ");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        PrintNumbers();
                        break;
                    case "2":
                        PerformAlgebra();
                        break;
                    case "3":
                        WorkWithNames();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void PrintNumbers()
        {
            Console.WriteLine("Enter start value: ");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter end value: ");
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void PerformAlgebra()
        {
            while (true)
            {
                Console.WriteLine("Algebra Submenu:");
                Console.WriteLine("1. Solve Equation y = 2x + 3");
                Console.WriteLine("2. Solve Equation y = ax^2 + bx");
                Console.WriteLine("3. Solve Equation y = a(x - b)(x + c)");
                Console.WriteLine("4. Return to Main Menu");
                Console.WriteLine("Enter your choice: ");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        SolveEquation1();
                        break;
                    case "2":
                        SolveEquation2();
                        break;
                    case "3":
                        SolveEquation3();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void SolveEquation1()
        {
            Console.WriteLine ("Enter value for x: ");
            double x = double.Parse(Console.ReadLine());

            double y = 2 * x + 3;
            Console.WriteLine($"The result of the equation y = 2x + 3 is y = {y}");
        }

        static void SolveEquation2()
        {
            Console.WriteLine ("Enter value for a: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter value for b: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter value for x: ");
            double x = double.Parse(Console.ReadLine());

            double y = a * x * x + b * x;
            Console.WriteLine($"The result of the equation y = ax^2 + bx is y = {y}");
        }

        static void SolveEquation3()
        {
            Console.WriteLine("Enter value for a: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter value for b: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter value for c: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter value for x: ");
            double x = double.Parse(Console.ReadLine());

            double y = a * (x - b) * (x + c);
            Console.WriteLine($"The result of the equation y = a(x - b)(x + c) is y = {y}");
        }

        static void WorkWithNames()
        {
            Console.WriteLine("How many names would you like to enter? ");
            int count = int.Parse(Console.ReadLine());

            string[] names = new string[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Enter name {i + 1}: ");
                names[i] = Console.ReadLine();
            }

            Console.WriteLine("You have entered the following names:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Division by zero is not allowed.");
                return double.NaN;
            }
            return a / b;
        }
    } //End of class
}
