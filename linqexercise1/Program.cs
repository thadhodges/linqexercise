internal class Program
{
    private static void Main(string[] args)
    {
        var nameList = new List<string>() { "123", "123456", "12345678", "12", "12345678910", "12345" };

        var sortByLength = nameList.OrderBy(x => x.Length);
        Console.WriteLine("list by ascending order");
        foreach (var item in sortByLength)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        Console.WriteLine("list by descending order");
        var descSort = nameList.OrderByDescending(x => x.Length);
        foreach (var item in descSort)
        {
            Console.WriteLine(item);
        }
        System.Console.WriteLine();
        System.Console.WriteLine(   );

        //additional code testing
        var nameListArrowStrength = new List<int> {11,21,31,41,51,61,71,81,91};
        int number5 = nameListArrowStrength[4];
        Random random = new Random();


        System.Console.WriteLine($"Random selection from list: {nameListArrowStrength[random.Next(0, nameListArrowStrength.Count)]}");

        //System.Console.WriteLine(number5);
    }

}
        