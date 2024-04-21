int[] arr = {1, -24, -6, 25, 88, -7, 2, 10};
int counter = 0;

foreach (var num in arr) 
{
    if (num > 0) 
    {
        counter++;
    }
}
Console.WriteLine("Кол-во положительных чисел в массиве: " + counter);