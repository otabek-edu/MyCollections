using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MyItems.Backend.Dtos;
using MyItems.Backend.Models;
using System.ComponentModel.DataAnnotations;

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

            var UUIDList = new List<Guid>();
            var collections = new List<Collection>();
            
            // Add 10 users
            for (int i = 0; i < 10; i++)
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

            // Add 1 admin
            _modelBuilder.Entity<User>().HasData
            (
                new User
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Admin",
                    LastName = "Admin",
                    Email = "otabek.pro@hotmail.com",
                    IsAdmin = true,
                    IsBlocked = false,
                    PasswordHash = "AQAAAAIAAYagAAAAEJsQhxvRZnTRqO2Jk9q/36tRhT1LD9BIAUsMuO2YrxZ4UlTc6QRjTD5Cbb7uA/sSsw=="
                }
            );

            // Add 10 collections
            for (int i = 0; i < 10; i++)
            {
                faker = new Bogus.Faker();
                uuid = Guid.NewGuid();

                var collection = new Collection
                {
                    Id = uuid,
                    Name = faker.Commerce.ProductName(),
                    Theme = faker.Commerce.ProductAdjective(),
                    ImageUrl = faker.Image.PicsumUrl(),
                    Description = faker.Commerce.ProductDescription(),
                    UserId = UUIDList[faker.Random.Int(0, 9)],
                };

                _modelBuilder.Entity<Collection>().HasData(collection);
                collections.Add(collection);
            }

            // Add 10 custom properties
            for (int i = 0; i < 10; i++)
            {
                faker = new Bogus.Faker();
                uuid = Guid.NewGuid();

                var currentCollection = collections[faker.Random.Int(0, 9)];

                _modelBuilder.Entity<CustomProperty>().HasData
                (
                    new CustomProperty()
                    {
                        Id = uuid,
                        Name = faker.Commerce.ProductName(),
                        Collection = currentCollection,
                        CollectionId = currentCollection.Id,
                        TypeProperty = DataType.Text
                    }
                );
            }

            // Add 10 items
            for (int i = 0; i < 10; i++)
            {
                faker = new Bogus.Faker();
                uuid = Guid.NewGuid();

                var currentCollection = collections[faker.Random.Int(0, 9)];

                _modelBuilder.Entity<Item>().HasData
                (
                    new Item()
                    {
                        Id = uuid,
                        UserId = UUIDList[faker.Random.Int(0, 9)],
                        Collection = currentCollection,
                        CreatedAt = DateTime.UtcNow,
                        Name = faker.Commerce.ProductName(),
                        Description = faker.Commerce.ProductDescription(),
                        CollectionId = UUIDList[faker.Random.Int(0, 9)],
                    }
                );
            }
        }
    }
}
