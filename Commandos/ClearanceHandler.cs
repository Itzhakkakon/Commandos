using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class ClearanceHandler
    {
        public static string GetName(string commanderRank, string name , string codeName)
        {

            if (commanderRank == "GENERAL")
            {
                return name;
            }
            else if (commanderRank == "COLONEL")
            {
                return codeName;
            }
            else
            {
                return "You are not authorized to see this information, it is classified information.";
            }
        }
    }
}
