void ShowArray(string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

    string[] finalArray = {"hello", "2", "world", ":-)"};
    //string[] finalArray = {"1234", "1567", "-2", "computer science"};
    //string[] finalArray = {"Russia", "Denmark", "Kazan"};
    string[] emptyArray = new string [4];


    for (int i=0; i<finalArray.Length; i++)
    {
      if (finalArray[i].Length <= 3)
     {
      emptyArray[i] = finalArray[i];

      }
    }

  ShowArray(emptyArray);