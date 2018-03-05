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
        public JsonResult Post([FromBody]TodoViewModel entity) {
            var todo = new TodoModel(entity.Title);
            repo.Add(todo);

            return Json(todo);
        }
    }
}
