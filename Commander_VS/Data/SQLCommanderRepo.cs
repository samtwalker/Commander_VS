using System;
using System.Collections.Generic;
using System.Linq;
using Commander_VS.Models;

namespace Commander_VS.Data
{
    public class SQLCommanderRepo : ICommanderRepo
    {
        private CommanderContext _context;

        public SQLCommanderRepo(CommanderContext context)
        {
            _context = context;
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandByID(int id)
        {
            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }
    }
}

