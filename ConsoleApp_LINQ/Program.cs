
using ConsoleApp_LINQ.Extentions;
using SeedData.Models;
using System.Data;

Console.WriteLine("Hello, World!");

var ahmedList = Filter.GetAhmeds(GetData.GetCustomers());
foreach (var ahmed in ahmedList)
{
    Console.WriteLine($"name = {ahmed.Name} age = {ahmed.Age}");
}