int SearchNumberStrings(string[] arrayStrings)
{
    int count = 0;
    for (int i = 0; i < arrayStrings.Length; i++)
    {
        if (arrayStrings[i].Length <= 3)
            count++;
    }
    return count;
}

void PrintArray(string[] str)
{
    for (int i = 0; i < str.Length; i++) Console.Write($"{str[i]} ");
    Console.WriteLine();
}


string[] strings = {"hello", "Array", "b123","01","mam"};
int number=SearchNumberStrings(strings);
string[] stringLength3 = new string[number];
int j = 0;
for (int i = 0; i < strings.Length; i++)
{
    if (strings[i].Length <= 3)
    {
        stringLength3[j] = strings[i];
        j++;
    }
}

PrintArray(strings);
PrintArray(stringLength3);