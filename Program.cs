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

Random dice = new Random();

int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 ==roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total +=2;
    }
}

if (total >= 15)
{
    Console.WriteLine("You win");
}
else
{
    Console.WriteLine("Sorry, you lose.");
}