List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
List<string> stringList = new List<string>()
{ "Nader", "Yasser", "Mo salah", "Rashad","ahmed ahmed","ahmed mohamady" };
//var result = Enumerable.Where(numbers, n => n > 5);
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine("----------------------------------------------------------------");
//var numberResult = numbers.Where(n => n > 5);
//foreach (var item in numberResult)
//{
//    Console.WriteLine(item);
//}

//var names = stringList.Where(x => x.Contains("ahmed"));
//foreach (var item in names)
//{
//   Console.WriteLine(item);
//}

//stringList.AddRange(new string[] { "saeed", "ahmed morad", "ahmed ahmed" });

var customers = GetData.GetCustomers()
    .Where(x => x.Age > 30)
    .Select(
    a => new
    {
        customerName = a.Name,
        customerTelephone = a.Telephone,
        customerAge = a.Age,
    }
);
foreach (var item in customers)
{
    Console.WriteLine(item);
}
