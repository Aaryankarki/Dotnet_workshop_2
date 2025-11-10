
Console.Write("Enter a number N: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= N; i++)
{
    sum += i;
}
Console.WriteLine("Sum = " + sum);


int num = 1;
while (num <= 20)
{
    if (num == 15)
        break;
    if (num % 4 == 0)
    {
        num++;
        continue;
    }
    Console.Write(num + " ");
    num++;
}
Console.WriteLine();


int[] arr = { 1, 5, 9, 7, 3 };
int total = 0;

foreach (int value in arr)
{
    total += value;
}
Console.WriteLine("Sum of Array Elements: " + total);
