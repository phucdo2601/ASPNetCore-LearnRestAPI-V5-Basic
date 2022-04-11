﻿using System.ComponentModel.DataAnnotations;

namespace LearnAspNetCoreRestAPIV5.DTOs
{
    public record CreateItemDto
    {
        [Required]
        public string Name { get; init; }
        [Required]
        [Range(1, 1000)]
        public decimal Price { get; init; }
    }
}
