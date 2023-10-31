using CloudCustomers.API.Models;

namespace CloudCustomers.UnitsTests.Fixtures;

public static class UsersFixture
{
    public static List<User> GetTestUsers() =>
    new()
    {
        new User()
        {
            Id = 1,
            Name = "Test User 1",
            Address = new Address(){
                Street = "123 Denver St",
                City = "Denver",
                ZipCode = "53704"
            },
            Email = "user1@email.com"
        },
        new User()
        {
            Id = 2,
            Name = "Test User 2",
            Address = new Address(){
                Street = "123 Denver St",
                City = "Denver",
                ZipCode = "53704"
            },
            Email = "user2@email.com"
        },
        new User()
        {
            Id = 3,
            Name = "Test User 3",
            Address = new Address(){
                Street = "123 Denver St",
                City = "Denver",
                ZipCode = "53704"
            },
            Email = "user3@email.com"
        }
    };
}