//Tommy Hudson Unit 3 Target Net Worth Calculator
namespace target_net_worth
{
    class Calculator
    {
        static void Main(string[] args)
        {
            //Title and Intro
            Console.WriteLine("\t\t\tCurrent Net Worth vs Target Net Worth");
            Console.WriteLine("This is a program to show your current net worth vs your target net worth.");
            Console.WriteLine("Target Net Worth = (Age*Annual Pre-Tax Income)*0.1");
            //Variables
            char answer;
            string tempAge, tempLiability, tempAsset,tempMaxLiabilities, tempMaxAssets, tempIncome;
            int age, maxLiabilities, maxAssets;
            bool res;
            double liability, asset, income, targetNetWorth, currentNetWorth, sumAssets = 0, sumLiabilities = 0;
            List<double> liabilities = new List<double>();
            List<double> assets = new List<double>();
            do
            {
                //Get age and income
                Console.Write("First please enter your age:");
                tempAge = Console.ReadLine();
                res = int.TryParse(tempAge, out age);
                while (res == false || age <1 || age >120)
                {
                    Console.Write("Error.\nPlease enter your age:");
                    tempAge = Console.ReadLine();
                    res = int.TryParse(tempAge, out age);
                }
                Console.Write("First please enter your annual pre-tax income:");
                tempIncome = Console.ReadLine();
                res = double.TryParse(tempIncome, out income);
                while (res == false || income < 0)
                {
                    Console.Write("Error.\nPlease enter your annual pre-tax income:");
                    tempAge = Console.ReadLine();
                    res = double.TryParse(tempIncome, out income);
                }
                //Get number of liabilities
                Console.Write("Please enter the max number of liabilities you have:");
                tempMaxLiabilities = Console.ReadLine();
                res = int.TryParse (tempMaxLiabilities, out maxLiabilities);
                while (res == false || maxLiabilities<0)
                {
                    Console.Write("Error.\nPlease enter the max number of liabilities you have:");
                    tempMaxLiabilities = Console.ReadLine();
                    res = int.TryParse(tempMaxLiabilities, out maxLiabilities);
                }
                //Get liabilities
                for (int i = 0; i < maxLiabilities; i++)
                {
                    Console.Write("Liability " + (i+1) + ":");
                    tempLiability = Console.ReadLine();
                    res = double.TryParse(tempLiability, out liability);
                    while (res == false || liability < 0)
                    {
                        Console.Write("Error.\nLiability " +(i+1)+":");
                        tempLiability = Console.ReadLine();
                        res = double.TryParse(tempLiability, out liability);
                    }
                    liabilities.Insert(i, liability);
                    sumLiabilities += liability;
                }
                //Get number of assets
                Console.Write("Please enter the max number of assets you have:");
                tempMaxAssets = Console.ReadLine();
                res = int.TryParse(tempMaxAssets, out maxAssets);
                while (res == false || maxAssets < 0)
                {
                    Console.Write("Error.\nPlease enter the max number of assets you have:");
                    tempMaxAssets = Console.ReadLine();
                    res = int.TryParse(tempMaxAssets, out maxAssets);
                }
                //Get assets
                for (int i = 0; i < maxAssets; i++)
                {
                    Console.Write("Asset " + (i + 1) + ":");
                    tempAsset = Console.ReadLine();
                    res = double.TryParse(tempAsset, out asset);
                    while (res == false || asset < 0)
                    {
                        Console.Write("Error.\nAsset " + (i + 1) + ":");
                        tempLiability = Console.ReadLine();
                        res = double.TryParse(tempAsset, out asset);
                    }
                    assets.Insert(i, asset);
                    sumAssets += asset;
                }
                //Sort lists
                liabilities.Sort((y,x) => y.CompareTo(x));
                assets.Sort((y, x) => y.CompareTo(x));
                //Print lists
                Console.WriteLine("List of Liabilities");
                foreach (double l in liabilities)
                {
                    int number = 1;
                    Console.WriteLine("{0}. {1}",number,l);
                    number++;
                }
                Console.WriteLine("List of Assets");
                foreach (double a in assets)
                {
                    int number = 1;
                    Console.WriteLine("{0}. {1}", number, a);
                    number++;
                }
                //Sums and calculated net worth
                Console.WriteLine("Sum of Liabilities = {0}", sumLiabilities);
                Console.WriteLine("Sum of Assets = {0}", sumAssets);
                currentNetWorth = sumAssets - sumLiabilities;
                targetNetWorth = (age * income) * .1;
                Console.WriteLine("Calculated Net Worth = {0}", currentNetWorth);
                Console.WriteLine("Target Net Worth = ({0}*{1})*0.10 = {2}", age, income, targetNetWorth);
                //Give comparison analysis
                if (targetNetWorth < currentNetWorth)
                {
                    Console.WriteLine("Great job you are beating expectations!");
                }
                if (currentNetWorth < targetNetWorth)
                {
                    Console.WriteLine("You still have some work to do before you reach your target net worth.");
                }
                //Ask if they want to run the calculator again
                Console.Write("Would you like to run calculator again? Y/N");
                answer = (char)Console.Read();
            } while (answer == 'Y'|| answer == 'y');
        }
    }
}