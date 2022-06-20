var result = pairs(2, new List<int>() { 1, 5, 3, 4, 2 });

Console.WriteLine(result);

int pairs(int k, List<int> arr)
{
    Dictionary<int, bool> valuesDict = new Dictionary<int, bool>();
    int count = 0;

    foreach (var i in arr)
    {
        if (valuesDict.ContainsKey(i - k))
            count += 1;

        if (valuesDict.ContainsKey(i + k))
            count += 1;

        valuesDict[i] = true;
    }

    return count;
}