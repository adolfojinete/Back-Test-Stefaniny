//using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPerson.Repositories;

namespace WebApiPerson.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly PersonRepository _personRepository;
        public PersonController()
        {
            _personRepository = new PersonRepository();
        }

        [HttpGet("people")] //EndPoint
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<IEnumerable<Models.Person>> GetAllPersons()
        {
            try
            {
                return _personRepository.GetAllPeople().ToList(); //Ok
            }
            catch (Exception)
            {
                //Error 400
                return BadRequest();
            }
        }

        [HttpPost("create")] //EndPoint
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Models.Person> AddPerson(Models.Person person)
        {
            try
            {
                person.Age = DateTime.Now.Year - person.BirthDate.Year;
                return _personRepository.AddPerson(person); //201
            }
            catch (Exception)
            {
                return BadRequest(); //400
            }
        }

    }
}
