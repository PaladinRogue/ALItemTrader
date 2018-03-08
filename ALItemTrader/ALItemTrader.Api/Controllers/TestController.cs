using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace ALItemTrader.Api.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        // GET api/test
        [HttpGet]
        public TestModel Get()
        {
            return new TestModel(Guid.NewGuid(), "SomeName", 15);
        }

        // GET api/test/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public TestModel Post([FromBody]TestModel model)
        {
            return model;
        }
    }

    public class TestModel
    {
        public TestModel()
        {
        }

        public TestModel(Guid id, string name, int level)
        {
            Id = id;
            Name = name;
            Level = level;
        }

        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        public int Level { get; set; }
    }
}