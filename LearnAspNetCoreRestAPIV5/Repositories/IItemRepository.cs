using LearnAspNetCoreRestAPIV5.Entities;
using System;
using System.Collections.Generic;

namespace LearnAspNetCoreRestAPIV5.Repositories
{
    public interface IItemRepository
    {
        Item GetItemById(Guid Id);
        IEnumerable<Item> GetItems();
        void CreateItem(Item item); 
        void UpdateItem(Item item);
        void DeleteItem(Guid Id);   
    }
}