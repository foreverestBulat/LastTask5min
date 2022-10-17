int n = 7;

Random rnd = new Random();

int[] arr = new int[rnd.Next(10, 20)];

for (int i = 0; i < n; i++)
{
    arr[i] = rnd.Next(1, 20);
    Console.Write($"{arr[i]}" + "\t");
}
Console.WriteLine();


int max = 0;
int min = 10000;
for (int i = 0; i < n; i++)
{
    if (max < arr[i])
    {
        max = arr[i];
    }

    if (min > arr[i])
    {
        min = arr[i];
    }
}

int sum = 0;

bool a = false;
for (int i = 0; i < n; i++)
{
    if (arr[i] == max)
    {
        a = true;
    }
    if (arr[i] == min)
    {
        a = false;
    }
    if (a)
    {
        sum += arr[i];
    }
}
if (a)
{
    sum = 0;
}
else sum -= max;

Console.WriteLine(sum);