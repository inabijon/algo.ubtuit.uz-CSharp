int a = 0;
int b = 0;
int c = 0;

Console.Write("Please enter a: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter b: ");
b = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter c: ");
c = Convert.ToInt32(Console.ReadLine());

if(a < 0 || b < 0 || c < 0) {
    Console.WriteLine("Invalid input");
    Console.WriteLine("Press any key to exit");
    Console.ReadKey();
    return;
}

double perimeter = Math.Round((a+b+c)* 0.5, 2);

string stringPerimeter = perimeter.ToString("0.00");

Console.WriteLine("The area of the sphere is: " + stringPerimeter);

Console.WriteLine("Press any key to exit");
Console.ReadKey();