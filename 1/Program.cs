//Find the volume of a cube of dimension x.

double x = 0.0;

Console.WriteLine("Enter a number: ");

x = Convert.ToDouble(Console.ReadLine());

double y = Math.Pow(x, 3);

Console.WriteLine("The cube of " + x + " is " + y);
