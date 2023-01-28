var nameList = new List<string>() { "123", "123456", "12345678", "12", "12345678910", "12345"};

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