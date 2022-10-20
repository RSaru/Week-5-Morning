
int[] numbers = new int[5];

for (int i =0; i<5; i++)
{
    Console.WriteLine("Enter a number: " + i);
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

Array.Sort(numbers);

Console.WriteLine("The Highest Number is " + numbers[4]);
Console.WriteLine("The Lowest Number is " + numbers[0]);

Console.ReadLine();