/*
int[] numbers = new int[5];

for (int i =0; i<5; i++)
{
    Console.WriteLine("Enter a number: " + i);
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

Array.Sort(numbers);

Console.WriteLine("The Highest Number is " + numbers[4]);
Console.WriteLine("The Lowest Number is " + numbers[0]);
*/

int radius;
Console.WriteLine("Welcome to my program");

double areaCalc()
{
    Console.WriteLine("Enter a radius");
    radius = Convert.ToInt32(Console.ReadLine());
    double answer = Math.PI * (radius*radius);
    return answer;
}

int circum;

double cirCalc()
{
    Console.WriteLine("Enter a radius");
    circum = Convert.ToInt32(Console.ReadLine());
    double answer = 2* Math.PI * radius;
    return answer;
}
Console.ReadKey();

Console.WriteLine("area is " + areaCalc());
//basically just prints answer but makes it more user friendly
Console.WriteLine("The Circumphrence is " + cirCalc());
Console.ReadKey();
