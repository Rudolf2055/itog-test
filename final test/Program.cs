int size = 5;
string [] arr = new string [size];
arr[0] = "66";
arr[1] = "Hello world!";
arr[2] = "What's up?";
arr[3] = "Have a good day";
arr[4] = "!";


int FindSizeOfArr(string [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}
