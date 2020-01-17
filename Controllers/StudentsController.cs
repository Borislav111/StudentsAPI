using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Models;
using WebApi.Services;
using WebApi.StudentsContext;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly StudentManager _manager;

        public StudentsController(StudentManager manager)
        {
            _manager = manager;
        }

        // GET: api/Students
        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(_manager.getAll());
        }
        [HttpPost]
        public IActionResult PostStudents(Students students)
        {

            _manager.Add(students);

            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            Students students = _manager.Get(id);
            if (students == null)
            {
                return NotFound("Not Found!");
            }
            _manager.Delete(students);
            return NoContent();
        }
    }
}

        