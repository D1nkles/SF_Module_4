var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
int current = 0;

for (int i = 0; i < arr.Length; i++) 
{

    for (int k = i; k < arr.Length; k++) 
    {
        if (arr[i] > arr[k]) 
        {
            current = arr[i];
            arr[i] = arr[k];
            arr[k] = current;
        }
    }
}

foreach (var num in arr) 
{
    Console.Write(num + " ");
}
