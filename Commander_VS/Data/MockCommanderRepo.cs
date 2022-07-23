using System;
using System.Collections.Generic;
using Commander_VS.Models;

namespace Commander_VS.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil Water", Platform = "Kettle" },
                new Command { Id = 1, HowTo = "Cut bread", Line = "Get Knife", Platform = "board" },
                new Command { Id = 2, HowTo = "make tea", Line = "Brew Cup", Platform = "Cup" }
        };
            return commands;
        }

        public Command GetCommandByID(int id)
        {
            return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil Water", Platform = "Kettle" };
        }

    }
}

