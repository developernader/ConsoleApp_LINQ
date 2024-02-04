using SeedData.Models;

public static class GetData
{
    public static List<CustomerCategory> GetCategories()
    {
        List<CustomerCategory> categories = new List<CustomerCategory>();
        categories.Add(new CustomerCategory() { Id = 1, Name = "Normal" }); ;
        categories.Add(new CustomerCategory() { Id = 1, Name = "VIP" });
        return categories;
    }

    public static List<Customer> GetCustomers()
    {
        List<Customer> customers = new List<Customer>();
        customers.Add(new Customer() { Id = 101, Name = "Ahmed mohamed", Age = 30, IsActive = true, JoinDate = new DateTime(2022, 10, 15), SpendAverage = 1500.9m, Telephone = 0106188853 });
        customers.Add(new Customer() { Id = 102, Name = "Ali Gamal", Age = 34, IsActive = false, JoinDate = new DateTime(2022, 09, 27), SpendAverage = 9999.2m, Telephone = 0123030150 });
        customers.Add(new Customer() { Id = 103, Name = "Yasser Rashad", Age = 36, IsActive = true, JoinDate = new DateTime(2022, 07, 05), SpendAverage = 5500.2m, Telephone = 01565465432 });
        customers.Add(new Customer() { Id = 104, Name = "Ahmed Naser", Age = 62, IsActive = false, JoinDate = new DateTime(2022, 03, 17), SpendAverage = 4503.3m, Telephone = 01074848480 });
        customers.Add(new Customer() { Id = 105, Name = "Ashraf Mazeed", Age = 50, IsActive = false, JoinDate = new DateTime(2022, 05, 02), SpendAverage = 6403.8m, Telephone = 01063632524 });
        customers.Add(new Customer() { Id = 106, Name = "Ahmed Nader", Age = 25, IsActive = true, JoinDate = new DateTime(2022, 07, 15), SpendAverage = 6425.1m, Telephone = 01287236012 });
        return customers;
    }

}