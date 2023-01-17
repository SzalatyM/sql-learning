using Bogus;
using static Bogus.DataSets.Name;

namespace TestDataGenerator;

public static class UsersGenerator
{
    public static IEnumerable<User> Run(int count)
    {
        int userId = 0;

        var fakeUsers = new Faker<User>("pl")
            .RuleFor(_ => _.UserId, f => ++userId)
            .RuleFor(_ => _.Gender, f => f.PickRandom<Gender>())
            .RuleFor(_ => _.FirstName, (f, u) => f.Name.FirstName(u.Gender))
            .RuleFor(_ => _.LastName, (f, u) => f.Name.LastName(u.Gender))
            .RuleFor(_ => _.Age, f => f.Random.Number(15, 70))
            .RuleFor(_ => _.City, f => f.Person.Address.City);

        return fakeUsers.Generate(count);
    }
}

public class User
{
    public int UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
    public Gender Gender { get; set; }
}

