string[] array = new string[7] {"1234", "-2", "comp", "sdf", "-987", "23", "5"};
string[] array1 = new string[array.Length];
void SecondArray(string[] array, string[] array1)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        array1[count] = array[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArray(array, array1);
PrintArray(array1);