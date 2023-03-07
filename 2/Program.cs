double r1 = 0.0;
double r2 = 0.0;
double r3 = 0.0;

Console.Write("Enter the first resistor value: ");
r1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the second resistor value: ");
r2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the third resistor value: ");
r3 = Convert.ToDouble(Console.ReadLine());

if(r1 < 0 || r2 < 0 || r3 < 0)
{
    Console.WriteLine("Invalid input");
    Console.WriteLine("Press any key to exit");
    Console.ReadKey();
    return;
}

double s1 = Math.Round(r1 * r1 * Math.PI, 2);
double s2 = Math.Round(r2 * r2 * Math.PI, 2);
double s3 = Math.Round(r3 * r3 * Math.PI, 2);

// Second way to do it
// string result1 = s1.ToString("0.00");
// string result2 = s2.ToString("0.00");
// string result3 = s3.ToString("0.00");

Console.WriteLine("The first resistor area is: " + s1);
Console.WriteLine("The second resistor area is: " + s2);
Console.WriteLine("The third resistor area is: " + s3);
    
Console.WriteLine("Press any key to exit");
Console.ReadKey();