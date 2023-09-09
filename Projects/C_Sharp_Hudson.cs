//Tommy Hudson Unit 1 Assignment

//Poem
Console.WriteLine("You might not have been my first love\nbut you were the love that made\nall the other loves\nirrelevant\n-Rupi Kaur\n\n");

//Data types
int x = 1, y = 5, z = 10;
double xx = 1.0, yy = 5.0, zz = 10.0;
char letter = 'a';
bool example = false;
string name = "Tommy";

//User input
Console.WriteLine("Please type your name and then press enter.");
string userName = Console.ReadLine();

//Calculations
int add = y + z, subtract = z - y, multiply = x * z;
double mod = yy % zz, divide = yy / zz;

//If statement
if (userName == name)
{
    Console.WriteLine("You have the same name as the developer!\n");
}
else
{
    Console.WriteLine("Your name is differant from the developer.\n");
}

//For loop
Console.WriteLine();
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("For Loop #" + (i + 1));
}

//While loop
Console.WriteLine();
int j = 0;
while (j < 5)
{
    Console.WriteLine("While Loop #" + (j + 1));
    j++;
}

//Do-While Loop
char answer;
string convert;
do
{
    answer = ' ';
    convert = " ";
    Console.WriteLine("\nThis is a do-while loop.");
    Console.WriteLine("Would you like for it to loop again?");
    Console.WriteLine("Y/N?");
    answer = (char)Console.Read();
    convert = answer.ToString();
    convert = convert.ToUpper();
} while (convert == "Y");

//foreach Loop using a string array
Console.WriteLine();
string[] jobs = { "Cashier", "Stocker", "Associate", "Manager" };
foreach (string i in jobs)
{
    Console.WriteLine(i);
}

//Function definition
static void functionExample()
{
    Console.WriteLine("\nThis line is part of a static void function.");
}

//Function call
Console.WriteLine();
functionExample();

//Declaring and initializing arrays
int[] integerArray = new int[] { 0, 1, 2 };
double[] doubleArray = new double[3];
doubleArray[0] = 10.0;
doubleArray[1] = 20.0;
doubleArray[2] = 30.0;
int[,] multiDimensionalArray = new int[2, 3];
int[][] jaggedArray = new int[2][];

//Input validation
Console.WriteLine("Please enter a number between 1 and 100.");
string input = Console.ReadLine();
int data;
int.TryParse(input, out data);
while (data < 1 || data > 100)
{
    Console.WriteLine("Input Error. Please enter a number between 1 and 100.");
    input = Console.ReadLine();
    int.TryParse(input, out data);
}

//Exception handling using try-catch blocks
try
{
    Console.WriteLine(integerArray[4]);
}
catch (IndexOutOfRangeException e)
{
    Console.WriteLine("An Exception has occurred.", e.Message);
}
//Declare a class
class Stuff
{
    string google = "https://www.google.com";
    static public void Foo()
    {
 //Using linked list data structures
        LinkedList<String> list = new LinkedList<String>();
        list.AddFirst("Website");
        list.AddLast("Example");
    }
}
//Syntax Differences
/* The syntax is very similar to C++ but not nearly as complex. It seems to be more intuitive than C++.
 * I'm still much more familiar with C++ and there are many warnings that I can't seem to find help with online
 * as I am programming this assignment. I can not for the life of me figure out why my data validation automatically
 * throws a failure without input.*/

//How to accept input through a form text box.
//All of my research makes it seem like you will need to use Visual Basic in some capacity but I don't really comprehend it.

//How to embed HTML
/*string body = @"<html><body>
<a href=""foo.bar"" class=""blap"">blip</a>
...
</body></html>";
or
string myString = System.IO.File.ReadAllText("path to the file");*/

//How to use SQL
/*using System;
using System.Windows;
using MySql.Data.MySqlClient;


namespace Deportes_WPF
{

public partial class Login : Window
{
    private MySqlConnection connection;
    private string server;
    private string database;
    private string user;
    private string password;
    private string port;
    private string connectionString;
    private string sslM;

    public Login()
    {
        InitializeComponent();

        server = "server_name";
        database = "database_name";
        user = "user_id";
        password = "password";
        port = "3306";
        sslM = "none";

        connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);

        connection = new MySqlConnection(connectionString);
    }

    private void conexion()
    {
        try
        {
            connection.Open();

            MessageBox.Show("successful connection");

            connection.Close();
        }
        catch (MySqlException ex)
        {
            MessageBox.Show(ex.Message + connectionString);
        }
    }

    private void btn1_Click(object sender, RoutedEventArgs e)
    {
        conexion();
    }
  }

}*/
