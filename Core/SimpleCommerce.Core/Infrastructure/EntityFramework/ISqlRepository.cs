using System.Collections;
using System.Collections.Generic;

namespace SimpleCommerce.Core.Infrastructure.EntityFramework
{
    public interface ISqlRepository
    {
        void RunCommand(string command);
        void RunCommands(IEnumerable<string> commands);
        IEnumerable<string> ParseCommand(IEnumerable<string> lines);
    }
}