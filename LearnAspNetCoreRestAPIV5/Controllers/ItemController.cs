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

        //GET / items
        [HttpGet]
        public IEnumerable<ItemDto> GetItems()
        {
            var items = repository.GetItems().Select(item => item.AsDto());
            return items;
        }

        //Get /items/Id
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
    }
}
