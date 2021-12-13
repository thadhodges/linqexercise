var nameList = new List<string>() { "frogger", "pac-man", "galactica", "flapdap", "shopfunlogname"};

var sortByLength = nameList.OrderBy(x => x.Length);
Console.WriteLine("list by ascending order");
foreach ( var item in sortByLength )
{
    Console.WriteLine(item);
}
Console.WriteLine();
Console.WriteLine("list by descending order");
var descSort = nameList.OrderByDescending(x => x.Length);
foreach ( var item in descSort )
{
    Console.WriteLine(item);
}