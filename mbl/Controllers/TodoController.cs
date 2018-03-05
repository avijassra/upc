using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mbl.Domains;
using mbl.Data;
using System.Net.Http;

namespace mbl.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        TodoRepository repo = null;

        public TodoController() {
            repo = new TodoRepository("TodoApp.db", "TodoColl");
        }

        [HttpGet]
        public JsonResult  Get() {
            var allTodos = repo.GetAll();
            return Json(allTodos);
        }

        [HttpPost]
        public JsonResult Post([FromBody]NewTodo model) {
            var abc = this.Request;
            var todo = new TodoModel(model.Title);
            repo.Add(todo);

            return Json(todo);
        }
    }

    public class NewTodo {
        public string Title { get; set; }

        public bool IsWeb { get; set; }
    }
}
