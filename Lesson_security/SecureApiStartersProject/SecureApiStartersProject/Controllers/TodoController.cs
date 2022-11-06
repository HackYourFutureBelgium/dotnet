using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SecureApiStartersProject.DataLayer;

namespace SecureApiStartersProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodoRepository _todoRepository;

        public TodoController(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetTodoItem(string id)
        {
            var todoItem = await _todoRepository.Get(id);
            return Ok(todoItem);
        }

        [HttpPost]
        public async Task<IActionResult> PostTodoItem(string description)
        {
            var id = await _todoRepository.CreateAsync(description);
            return Ok(id);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteTodoItem(string id)
        {
            await _todoRepository.Delete(id);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTodoItem(string id, bool completed)
        {
            await _todoRepository.Update(id, completed);
            return Ok();
        }
    }
}
