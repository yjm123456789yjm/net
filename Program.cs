// using System.Diagnostics;
// int result = Fibonacci(5);
// Console.WriteLine(result);

// static int Fibonacci(int n)
// {
//     Debug.WriteLine($"Enter {nameof(Fibonacci)} method");
//     Debug.WriteLine($"We are looking for the {n}th number");
//     int n1 = 0;
//     int n2 = 1;
//     int sum;

//     for (int i = 2; i <= n; i++)
//     {
//         sum = n1 + n2;
//         n1 = n2;
//         n2 = sum;
//         Debug.WriteLineIf(sum==1, $"sum is 1, n1 is {n1}, n2 is {n2}");
//     }
//     Debug.Assert(n2==5, "The return value is not 5 and it should be.");
//     return n == 0 ? n1 : n2;
// }

// Random dice = new Random();
// int roll = dice.Next(1,7);
// Console.WriteLine(roll);

// Random dice = new Random();
// int roll1 = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50, 101);

// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");

// int firstValue = 500;
// int secondValue = 600;
// int largerValue;
// largerValue = Math.Max(firstValue, secondValue);
// Console.WriteLine(largerValue);

// Random dice = new Random();

// int roll1 = dice.Next(1,7);
// int roll2 = dice.Next(1,7);
// int roll3 = dice.Next(1,7);

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     if ((roll1 == roll2) && (roll2 ==roll3))
//     {
//         Console.WriteLine("You rolled triples!  +6 bonus to total!");
//         total += 6;
//     }
//     else
//     {
//         Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//         total +=2;
//     }
// }

// if (total >= 16)
// {
//     Console.WriteLine("You win a new car!");
// }
// else if (total >= 10)
// {
//     Console.WriteLine("You win a new laptop!");
// }
// else if (total == 7)
// {
//     Console.WriteLine("You win a trip for two!");
// }
// else
// {
//     Console.WriteLine("You win a kitten!");
// }

// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// if(daysUntilExpiration == 0)
// {
//     Console.WriteLine("Your subscription has expired.");
// }
// else if (daysUntilExpiration == 1)
// {
//     Console.WriteLine("Your subscription expires within a day!");
//     discountPercentage = 20;
// }
// else if (daysUntilExpiration <= 5)
// {
//     Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
//     discountPercentage = 10;
// }
// else if (daysUntilExpiration <= 10)
// {
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
// }

// if (discountPercentage > 0)
// {
//     Console.WriteLine($"Renew now and save {discountPercentage}%.");
// }

// Console.WriteLine("a" == "a");
// Console.WriteLine("a" == "A");
// Console.WriteLine(1 == 2);

// string myValue = "a";
// Console.WriteLine(myValue == "a");

// string value1 = " a";
// string value2 = "A ";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);

// string myValue = "a";
// Console.WriteLine(myValue != "a");

// Console.WriteLine(1 > 2);
// Console.WriteLine(1 < 2);
// Console.WriteLine(1 >= 1);
// Console.WriteLine(1 <= 1);

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("fox"));
// Console.WriteLine(pangram.Contains("cow"));

// Random coin = new Random();
// int flip = coin.Next(0,2);
// Console.WriteLine((flip == 0) ? "heads" : "tails");

// string permission = "Admin|Manager";
// int lever = 53;

// if (permission.Contains("Admin"))
// {
//     if (lever > 55)
//     {
//         Console.WriteLine("Welcome, super Admin user.");
//     }
//     else
//     {
//         Console.WriteLine("Welcome, Admin user.");
//     }
// }
// else if (permission.Contains("Manager"))
// {
//     if (lever >= 20)
//     {
//         Console.WriteLine("Contact an Admin for access.");
//     }
//     else
//     {
//         Console.WriteLine("You do not have suuficient privileges.");
//     }
// }
// else
// {
//     Console.WriteLine("You do not have sufficient privileges.");
// }

// bool flag = true;
// int value = 0;

// if (flag)
// {
//      value = 10;
//     Console.WriteLine("Inside of code block: " + value);
// }
// Console.WriteLine("Outside of code block: " + value);

// using System;

// namespace MyNewApp
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello World!");
//         }
//     }
// }

// using System;

// namespace MyNewApp
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string value = "Microsoft learn";
//             string reversedValue = Utilities.Utility.Reverse(value);
//             Console.WriteLine($"Secret message: {reversedValue}");
//         }
        
//     }
// }
// namespace MyNewApp.Utilities
// {
//     class Utility
//     {
//         public static string Reverse(string message)
//         {
//             char[] letters = message.ToCharArray();
//             Array.Reverse(letters);
//             return new string(letters);
//         }
//     }
// }

// bool flag = true;
// if (flag)
//     Console.WriteLine(flag);

// int[] numbers = { 4, 8, 15, 16, 23, 42 };
// int total = 0;
// bool found = false;

// foreach (int number in numbers)
// {
//     total += number;
//     if (number == 42) found = true;
    
// }
// if (found) Console.WriteLine("Set contains 42");

// Console.WriteLine($"Total: {total}");


// SKU = Stock Keeping Unit
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");