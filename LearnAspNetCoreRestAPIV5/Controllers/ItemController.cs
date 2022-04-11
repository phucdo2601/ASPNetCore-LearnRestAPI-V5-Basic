using LearnAspNetCoreRestAPIV5.DTOs;
using LearnAspNetCoreRestAPIV5.Entities;
using LearnAspNetCoreRestAPIV5.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LearnAspNetCoreRestAPIV5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {

        //khai bao bien de su depencyInjection
        private readonly IItemRepository repository;

        public ItemController(IItemRepository repository)
        {
            this.repository = repository;
        }

        //GET /api/ item
        [HttpGet]
        public IEnumerable<ItemDto> GetItems()
        {
            var items = repository.GetItems().Select(item => item.AsDto());
            return items;
        }

        //Get /api/item/Id
        [HttpGet("{Id}")]
        public ActionResult<ItemDto> GetItemById(Guid Id)
        {
            var item = repository.GetItemById(Id);
            if (item is null)
            {
                return NotFound();
            }
            return Ok(item.AsDto());
        }

        //POST /api/item
        [HttpPost]
        public ActionResult<ItemDto> CreateItem(CreateItemDto itemDto)
        {
            Item item = new()
            {
                Id = Guid.NewGuid(),
                Name = itemDto.Name,
                Price = itemDto.Price,
                CreatedDate = DateTimeOffset.UtcNow
            };

            repository.CreateItem(item);
            return CreatedAtAction(nameof(GetItemById), new { id = item.Id }, item.AsDto());
        }

        //Put /item/
        [HttpPut("{Id}")]
        public ActionResult UpdateItem(Guid Id, UpdateItemDto itemDto)
        {
            var existingItem = repository.GetItemById(Id);
            if (existingItem is null)
            {
                return NotFound();
            }

            Item updatedItem = existingItem with
            {
                Name = itemDto.Name,
                Price = itemDto.Price,

            };

            repository.UpdateItem(updatedItem); 

            return NoContent();
        }

        // DELETE /api/item/{Id}
        [HttpDelete("Id")]
        public ActionResult DeleteItemByItemId(Guid Id)
        {
            var exisitingItem = repository.GetItemById(Id);
            
            if (exisitingItem is null)
            {
                return NotFound();
            }

            repository.DeleteItem(Id);

            return NoContent();
        }

    }
}
