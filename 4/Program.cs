int r = 0;

Console.Write("Enter the number of radius: ");
r = Convert.ToInt32(Console.ReadLine());

if(r < 0)
{
    Console.WriteLine("Invalid input");
    Console.WriteLine("Press any key to exit");
    Console.ReadKey();
    return;
}

double area = Math.Round(4 * Math.PI * r * r, 2);

Console.WriteLine("The area of the sphere is: " + area);

Console.WriteLine("Press any key to exit");
Console.ReadKey();