using System;
using System.Collections.Generic;
using Commander_VS.Models;

namespace Commander_VS.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAllCommands();

        Command GetCommandByID(int id);

    }
}

