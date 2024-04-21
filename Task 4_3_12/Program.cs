var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
int current = 0;
int current_index = 0;
int max = 0;
int max_index = 0;
bool isSorted = false;

for (int i = 0; i < arr.Length; i++) 
{
    current = arr[i];
    current_index = i;
    for (int k = i; k < arr.Length; k++) 
    {
        if (current > arr[k]) 
        {
            arr[current_index] = arr[k];
            current_index = k;
            arr[k] = current;
        }
    }
    Console.Write(arr[i] + " ");
}


