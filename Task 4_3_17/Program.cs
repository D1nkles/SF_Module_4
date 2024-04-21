int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
int current = 0;

for (int i = 0; i <= arr.GetUpperBound(0); i++) 
{
    for (int k = 0; k <= arr.GetUpperBound(1); k++) 
    {
        for (int j = 0; j <= arr.GetUpperBound(1); j++) 
        {
            if (arr[i, k] < arr[i, j]) 
            {
                current = arr[i, k];
                arr[i, k] = arr[i, j];
                arr[i,j] = current;
            }
        }
    }
}

for (int row = 0; row <= arr.GetUpperBound(0); row++) 
{
    for (int column = 0; column <= arr.GetUpperBound(1); column++) 
    {
        Console.Write(arr[row, column] + " ");
    }
    Console.WriteLine();
}