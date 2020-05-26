using Kommand.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kommand.Data
{
   public  interface IKommanderRepo
    {


        IEnumerable<Command> GetAppKommand();
        //IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int id);
    }
}
