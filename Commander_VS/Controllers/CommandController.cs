using System;
using System.Collections.Generic;
using Commander_VS.Data;
using Commander_VS.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander_VS.Controllers
{

    //api/commands routing
    [Route("api/commands")]
    [ApiController]
    public class CommandController : ControllerBase
    {
        private readonly ICommanderRepo _repository;

        public CommandController(ICommanderRepo repository)
        {
            _repository = repository;
        }

        // this is not best practice but to test quicky -- see above constructor for dependency injection
        //private readonly MockCommanderRepo _repository = new MockCommanderRepo();

        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();

            return Ok(commandItems);
        }

        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandByID(int id)
        {
            var commandItem = _repository.GetCommandByID(id);

            return Ok(commandItem);
        }

    }
}

