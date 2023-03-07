double x = 0.00;
double y = 0.00;

Console.Write("Enter x: ");
x = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter y: ");
y = Convert.ToDouble(Console.ReadLine());

if(x <= 1 || y >= 10) {
    Console.WriteLine("Invalid input");
    Console.WriteLine("Press any key");
    Console.ReadKey();
}

double top = x + y;

double bottomTop = y * y + 2;
double bottomBottom = x + Math.Pow(x,3) /5;

double abs = Math.Abs(bottomTop / bottomBottom);

double BOTTOM = y * y + abs;

double additional = Math.Pow(Math.E, y + 2);

double total = Math.Round(top / BOTTOM + additional, 2);

Console.WriteLine("TOTAL SUM " + total);
Console.Write("Press any key");
Console.ReadKey();