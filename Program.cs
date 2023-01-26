
string[] EnterArray()
{
    Console.WriteLine("Please set the array (space separated):");
    string[] newArray = Console.ReadLine().Split(" ").ToArray();
    return newArray;
}

string[] ProcessArray(string[] someArray)
{
    int counter = 0;
    for (int i = 0; i < someArray.Length; i++)
    {
        if (someArray[i].Length<4)
        {
            counter++;
        }
    }

    string[] newArray = new string[counter];
 
    counter = 0;
    for (int i = 0; i < someArray.Length; i++)
    {
        if (someArray[i].Length<4)
        {
            newArray[counter] = someArray[i];
            counter++;
        }
    }
    return newArray;

}

void PrintArray(string[] someArray)
{
    Console.WriteLine($"{string.Join(" ", someArray)}");
}

Console.Clear();
string[] myArray = EnterArray();
string[] outputArray = ProcessArray(myArray);
Console.WriteLine("The following items are less than 4 chars:");
PrintArray(outputArray);
