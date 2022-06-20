string[] name = new string[5] {"Kai", "Ivan", "Tom", "Viner", "Sam"};
string[] array2 = new string[name.Length];
void CrearArray(string[] name, string[] array2)
{
    int count = 0;
    for (int i = 0; i < name.Length; i++)
    {
        if (name[i].Length <= 3)
        {
            array2[count] = name[i];
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
CrearArray(name, array2);
PrintArray(name);
PrintArray(array2);