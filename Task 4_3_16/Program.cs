int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
int counter = 0;

for (int i = 0; i <= arr.GetUpperBound(0); i++)
{
    for (int k = 0; k <= arr.GetUpperBound(1); k++) 
    {
        if (arr[i,k] > 0) 
        {
            counter++;
        }
    }
}
Console.WriteLine(counter);