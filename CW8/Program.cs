int[] GetOddNumbers(int[] array)
{
    List<int> oddNumbersList = new List<int>();
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            oddNumbersList.Add(array[i]);
        }
    }
    return oddNumbersList.ToArray();
}
int[] GetEvenNumbers(int[] array)
{
    List<int> oddNumbersList = new List<int>();
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            oddNumbersList.Add(array[i]);
        }
    }
    return oddNumbersList.ToArray();
}
int FindMax(int[] array)
{
    int max=array[0];
    for (int i=0;i<array.Length;++i)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}
