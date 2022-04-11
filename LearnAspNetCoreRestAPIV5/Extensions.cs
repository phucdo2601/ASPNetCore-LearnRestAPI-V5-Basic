﻿using LearnAspNetCoreRestAPIV5.DTOs;
using LearnAspNetCoreRestAPIV5.Entities;

namespace LearnAspNetCoreRestAPIV5
{
    public static class Extensions
    {
        public static ItemDto AsDto(this Item item)
        {
            return new ItemDto
            {
                Id = item.Id,
                Name = item.Name,
                Price = item.Price,
                CreatedDate = item.CreatedDate,
            };
        }
    }
}
