using Kommand.Data;
using Kommand.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kommand.Controllers
{
    //api controller
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase

    {
        
        
        private readonly IKommanderRepo _repo;

        public CommandsController(IKommanderRepo repo)
        {
            
            _repo = repo;
        }

        //private readonly MockKommanderRepo _repo = new MockKommanderRepo();
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repo.GetAppKommand();
            return Ok(commandItems);

        }
        //Get "api/[controller}/{id}

        [HttpGet("{id}")]
        public ActionResult<Command> GetById(int id)
        {
           var commandItems =  _repo.GetCommandById(id);
            return Ok(commandItems);
        }
    }
}
