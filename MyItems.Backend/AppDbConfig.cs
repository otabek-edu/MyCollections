using Microsoft.EntityFrameworkCore;
using MyItems.Backend.Models;

namespace MyItems.Backend
{
    public class AppDbConfig
    {
        private readonly ModelBuilder _modelBuilder;

        public AppDbConfig(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }

        public void Configure()
        {
            var faker = new Bogus.Faker();

            Guid uuid;

            List<Guid> UUIDList = new List<Guid>();

            for (int i = 0; i < 100; i++)
            {
                faker = new Bogus.Faker();
                uuid = Guid.NewGuid();
                UUIDList.Add(uuid);

                _modelBuilder.Entity<User>().HasData
                (
                    new User
                    {
                        Id = uuid,
                        FirstName = faker.Person.FirstName,
                        LastName = faker.Person.LastName,
                        Email = faker.Person.Email,
                        IsAdmin = false,
                        IsBlocked = false,
                        PasswordHash = ""
                    }
                );
            }
        }
    }
}
