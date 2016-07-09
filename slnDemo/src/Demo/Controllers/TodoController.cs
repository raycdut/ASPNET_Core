namespace Demo.Controllers
{
    using System.Collections.Generic;

    using Demo.Models;

    using Microsoft.AspNetCore.Mvc;

    [Route("api/todo")]
    public class TodoController : Controller
    {
        public TodoController(ITodoRepository todoItems)
        {
            this.TodoItems = todoItems;
        }

        public ITodoRepository TodoItems { get; set; }

        public IEnumerable<TodoItem> GetAll()
        {
            return this.TodoItems.GetAll();
        }

        [HttpGet("{id}", Name = "GetTodo")]
        public IActionResult GetById(string id)
        {
            var item = this.TodoItems.Find(id);
            if (item == null)
            {
                return this.NotFound();
            }
            return new ObjectResult(item);
        }

        //{

        //// GET: api/values
        //[HttpGet]

        //public IEnumerable<string> Get()
        //    return new[] { "value1", "value2" };
        //}

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}