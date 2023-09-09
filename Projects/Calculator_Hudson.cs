//Tommy Hudson Unit 2 Assignment C# Calculator
namespace calculator_c_sharp
{
    class Calculator
    {
        static void Main(string[] args)
        {
            string answer, temp1, temp2;
            bool res;
            double num1, num2, result;
            do
            {
                Console.Write("Number1:");
                temp1 = Console.ReadLine();
                res = double.TryParse(temp1, out num1);
                while (res == false)
                {
                    Console.Write("Error.\nPlease enter Number1:");
                    temp1 = Console.ReadLine();
                    res = double.TryParse(temp1, out num1);
                }
                Console.Write("Number2:");
                temp2 = Console.ReadLine();
                res = double.TryParse(temp2, out num2);
                while (res == false)
                {
                    Console.Write("Error.\nPlease enter Number2:");
                    temp1 = Console.ReadLine();
                    res = double.TryParse(temp2, out num2);
                }
                Console.Write("Operation:");
                string input = Console.ReadLine();
                string operation = input.ToLower();

                switch (operation)
                {
                    case ("+"):
                        result = num1 + num2;
                        Console.WriteLine("=" + result);
                        break;
                    case ("add"):
                        result = num1 + num2;
                        Console.WriteLine("=" + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine("=" + result);
                        break;
                    case "subtract":
                        result = num1 - num2;
                        Console.WriteLine("=" + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine("=" + result);
                        break;
                    case "multiply":
                        result = num1 * num2;
                        Console.WriteLine("=" + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine("=" + result);
                        break;
                    case "divide":
                        result = num1 / num2;
                        Console.WriteLine("=" + result);
                        break;
                    default:
                        Console.WriteLine("Input Error");
                        break;
                }
                Console.ReadLine();
                Console.Write("Would you like to run Calculator again (Y/N):");
                answer = Console.ReadLine();
            }
            while (answer == "y" || answer == "Y");
        }
    }

}