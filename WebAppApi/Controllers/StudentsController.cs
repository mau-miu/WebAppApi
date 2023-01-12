using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppApi.Data;
using WebAppApi.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly DB _Crudcontext;

        public StudentsController(DB Crudcontext)
        {
            _Crudcontext = Crudcontext;
        }
        // GET: api/<StudentsController>

        [HttpGet]
        public IEnumerable<Student> Get()
        {

            return  _Crudcontext.Students.ToList();
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}", Name = "Get")]
        public Student Get(int id)
        {
            return _Crudcontext.Students.SingleOrDefault(all => all.StudentId == id);
        }

        // POST api/<StudentsController>
        [HttpPost]
        public void Post([FromBody] Student student)
        {
            _Crudcontext.Students.Add(student);
            _Crudcontext.SaveChanges();
        }

        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] Student student)
        {
            _Crudcontext.Students.Update(student);
            _Crudcontext.SaveChanges();
        }

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item =_Crudcontext.Students.FirstOrDefault(all => all.StudentId == id);
            if(item != null)
            {
                _Crudcontext.Students.Remove(item);
                _Crudcontext.SaveChanges();
            }
        }
    }
}
