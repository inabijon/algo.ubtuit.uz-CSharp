int n = 0;

Console.Write("Please enter n: ");
n = Convert.ToInt32(Console.ReadLine());

if(n < 0) {
    Console.WriteLine("Result is - " + 1);
}

int sum = 0;

for(int i = 1; i<=n; i++) {
    sum += i;
}

Console.WriteLine("Total sum is " + sum);

Console.WriteLine("Press any key");
Console.ReadKey();