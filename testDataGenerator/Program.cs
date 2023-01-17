using TestDataGenerator;

var users = UsersGenerator.Run(100);

foreach(var user in users)
{
    Console.WriteLine($"({user.UserId}, '{user.FirstName}', '{user.LastName}', {user.Age}, '{user.City}'),");
}