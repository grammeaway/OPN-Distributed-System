using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using backend1.Model;

namespace backend1.Controllers
{
    [ApiController]
    public class PersonsController : ControllerBase
    {

        public PostgresContext context;
        public PersonsController(PostgresContext context)
        { 
            this.context = context;

        }
   
        [Route("getPersons")]
        [HttpGet]
        public ActionResult<IEnumerable<Person>> getPersons()
        {
            Console.WriteLine(context.Persons.ToList());
            return context.Persons.ToList();
        }

        
        [Route("insertPerson")]
        [HttpPost]
        public void Post([FromForm] Person person)
        {
            context.Persons.Add(person);
            context.SaveChanges();
            
        }
    }
}