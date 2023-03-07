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

double s1 = r1 * r1 * Math.PI;
double s2 = r2 * r2 * Math.PI;
double s3 = r3 * r3 * Math.PI;

string result1 = s1.ToString("0.00");
string result2 = s2.ToString("0.00");
string result3 = s3.ToString("0.00");

Console.WriteLine("The first resistor area is: " + result1);
Console.WriteLine("The second resistor area is: " + result2);
Console.WriteLine("The third resistor area is: " + result3);
    
Console.WriteLine("Press any key to exit");
Console.ReadKey();
