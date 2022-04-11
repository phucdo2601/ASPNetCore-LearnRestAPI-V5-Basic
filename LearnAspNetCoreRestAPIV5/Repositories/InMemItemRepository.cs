using System;
using LearnAspNetCoreRestAPIV5.Entities;
using System.Collections.Generic;
using System.Linq;

namespace LearnAspNetCoreRestAPIV5.Repositories
{
    public class InMemItemRepository
    {
        private readonly List<Item> items = new()
        {
            new Item
            {
                Id = System.Guid.NewGuid(),
                Name = "Potato", 
                Price = 10,
                CreatedDate = DateTimeOffset.UtcNow
            },
            new Item
            {
                Id = System.Guid.NewGuid(),
                Name = "Iron Sword",
                Price = 20,
                CreatedDate = DateTimeOffset.UtcNow
            },
            new Item
            {
                Id = System.Guid.NewGuid(),
                Name = "Bronze Shield",
                Price = 18,
                CreatedDate = DateTimeOffset.UtcNow
            },
        };

        public IEnumerable<Item> GetItems()
        {
            return items;
        }

        public Item GetItemById(Guid Id)
        {
            return items.Where(item => item.Id == Id).SingleOrDefault();
        }
    }
}
