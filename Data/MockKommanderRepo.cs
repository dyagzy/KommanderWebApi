using Kommand.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kommand.Data
{
    public class MockKommanderRepo : IKommanderRepo
    {
        //public IEnumerable<Command> GetAppCommands()
        //{
        //    throw new NotImplementedException();
        //}

        public IEnumerable<Command> GetAppKommand()
        {
            var commands = new List<Command>()
            {
                new Command { Id = 0, HowTo = "make a stew", Line = " Cook stew", Platform = "Kettle and spoon" },
                new Command { Id = 1, HowTo = "boil  a stew", Line = " Leek stew", Platform = "Kettle and cup" },
                new Command { Id = 2, HowTo = "fry a stew", Line = " Steam stew", Platform = "Kettle and Pan" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "amke a stew", Line = " Cook stew", Platform = "Kettle and Pan" };
        }
    }
}
