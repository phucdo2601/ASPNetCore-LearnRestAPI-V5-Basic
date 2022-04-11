using LearnAspNetCoreRestAPIV5.Entities;
using LearnAspNetCoreRestAPIV5.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;

namespace LearnAspNetCoreRestAPIV5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly InMemItemRepository repository;

        public ItemController()
        {
            repository = new InMemItemRepository();
        }

        //GET / items
        [HttpGet]
        public IEnumerable<Item> GetItems()
        {
            var items = repository.GetItems();
            return items;
        }

        //Get /items/Id
        [HttpGet("{Id}")]
        public ActionResult<Item> GetItemById(Guid Id)
        {
            var item = repository.GetItemById(Id);
            if (item is null)
            {
                return NotFound();
            }
            return Ok(item);
        }
    }
}
