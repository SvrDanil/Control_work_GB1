string [] arrayFirst = new string[5] {"Denmark","Hello","12","345","10"};
string [] arraySecond = new string [arrayFirst.Length];

void ArrayConverter(string[] arr1,string[] arr2)
{   
    int  j=0;
    for(int i =0 ;i<arr1.Length;i++)
    {
        if (arr1[i].Length<=3)
        {
            arr2[j]=arr1[i];
            j++;
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
ArrayConverter(arrayFirst, arraySecond);
PrintArray(arraySecond);