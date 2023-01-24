using Bogus;

namespace TestDataGenerator;

public class OrdersGenerator
{
    public static IEnumerable<Order> Run(int count)
    {
        int orderId = 0;

        var fakeUsers = new Faker<Order>("pl")
            .RuleFor(_ => _.OrderId, f => ++orderId)
            .RuleFor(_ => _.OrderDate, f => f.Date.Between(new DateTime(2022,1,1), new DateTime(2022,1,23)))
            .RuleFor(_ => _.UserId, f => f.Random.Number(1, 99));

        return fakeUsers.Generate(count);
    }
}

public class Order
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public int UserId { get; set; }
}
