using TestDataGenerator;

var orders = OrdersGenerator.Run(500);

foreach(var order in orders)
{
    Console.WriteLine($"({order.OrderId}, '{order.OrderDate.ToString("yyyy-MM-dd H:mm:ss")}', {order.UserId}),");
}