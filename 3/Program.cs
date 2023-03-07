double s = 0.00;
double h = 0.00;

Console.Write("Enter the number of square: ");
s = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of height: ");
h = Convert.ToInt32(Console.ReadLine());

if(s < 0 || h < 0)
{
    Console.WriteLine("Invalid input");
    Console.WriteLine("Press any key to exit");
    Console.ReadKey();
    return;
}

double area = 2* s / h;

string areaString = area.ToString("0.00");

Console.WriteLine("The area of the rectangle is: " + areaString);

Console.WriteLine("Press any key to exit");
Console.ReadKey();