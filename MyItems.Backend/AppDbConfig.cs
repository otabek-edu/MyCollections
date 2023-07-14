using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MyItems.Backend.Dtos;
using MyItems.Backend.Models;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;

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

            var users = new List<User>();
            var collections = new List<Collection>();
            var items = new List<Item>();

            var customProperties = new List<CustomProperty>();
            var customPropertyValues = new List<CustomPropertyValue>();

            var types = new List<string>() { "string", "number", "boolean", "dateTime"};
            
            // Add 1 admin
            var adminUser = new User
            {
                Id = Guid.NewGuid(),
                FirstName = "Admin",
                LastName = "Admin",
                Email = "otabek.pro@hotmail.com",
                IsAdmin = true,
                IsBlocked = false,
                PasswordHash = "AQAAAAIAAYagAAAAEJsQhxvRZnTRqO2Jk9q/36tRhT1LD9BIAUsMuO2YrxZ4UlTc6QRjTD5Cbb7uA/sSsw=="
            };
            _modelBuilder.Entity<User>().HasData(adminUser);

            // Add 10 users
            for (int i = 0; i < 10; i++)
            {
                faker = new Bogus.Faker();
                uuid = Guid.NewGuid();
                var user = new User
                {
                    Id = uuid,
                    FirstName = faker.Person.FirstName,
                    LastName = faker.Person.LastName,
                    Email = faker.Person.Email,
                    IsAdmin = false,
                    IsBlocked = false,
                    PasswordHash = ""
                };

                _modelBuilder.Entity<User>().HasData(user);
                users.Add(user);
            }

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
                    UserId = users[faker.Random.Int(0, 9)].Id
                };

                _modelBuilder.Entity<Collection>().HasData(collection);
                collections.Add(collection);
            }

            // Add 10 custom properties
            for (int i = 0; i < 10; i++)
            {
                faker = new Bogus.Faker();
                uuid = Guid.NewGuid();
                var currentCollection = collections[i];

                var customProperty = new CustomProperty()
                {
                    Id = uuid,
                    TypeProperty = types[faker.Random.Int(0, 3)],
                    CollectionId = currentCollection.Id
                };

                _modelBuilder.Entity<CustomProperty>().HasData(customProperty);
                customProperties.Add(customProperty);
            }

            // Add 10 items
            for (int i = 0; i < 10; i++)
            {
                faker = new Bogus.Faker();
                uuid = Guid.NewGuid();

                var currentCollection = collections[i];

                var item = new Item()
                {
                    Id = uuid,
                    Name = faker.Commerce.ProductName(),
                    CreatedAt = faker.Date.Past(),
                    CollectionId = currentCollection.Id
                };

                _modelBuilder.Entity<Item>().HasData(item);
                items.Add(item);
            }



            // Add 10 custom properties values
            for (int i = 0; i < 10; i++)
            {
                faker = new Bogus.Faker();
                uuid = Guid.NewGuid();

                var currentCollectionId = collections[i].Id;
                var currentCustomProperty = customProperties.FirstOrDefault(x => x.CollectionId == currentCollectionId);
                var currentItem = items.FirstOrDefault(x => x.CollectionId == currentCollectionId);
                Console.WriteLine(currentCustomProperty);
                Console.WriteLine(currentItem);
                if (currentCustomProperty != null && currentItem != null)
                {
                    var customPropertyValue = new CustomPropertyValue()
                    {
                        Id = uuid,
                        Value = faker.Commerce.ProductName(),
                        CustomPropertyId = currentCustomProperty.Id,
                        ItemId = currentItem.Id
                    };
                    
                    _modelBuilder.Entity<CustomPropertyValue>().HasData(customPropertyValue);
                    customPropertyValues.Add(customPropertyValue);
                    Console.WriteLine($"Added {customPropertyValue.Value}");
                }
            }
        }
    }
}
