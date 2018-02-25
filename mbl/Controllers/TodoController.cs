using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mbl.Domains;
using mbl.Data;

namespace mbl.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        TodoRepository repo = null;

        public TodoController() {
            repo = new TodoRepository("TodosDatabase", "Todos", "mongodb://127.0.0.1:27017");
        }

        [HttpGet]
        public async Task<JsonResult>  Get() {
            var allTodos = await repo.GetAll();

            return Json(allTodos);
        }

        [HttpPost]
        public async Task Post(TodoModel entity) {
            await repo.Add(entity);
        }
    }
}
