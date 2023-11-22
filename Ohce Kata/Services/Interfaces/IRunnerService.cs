using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohce_Kata.Services.Interfaces
{
    public interface IRunnerService
    {
        void Run();
        void SetupName();
        string GetNameFromConsole();
        bool isInvalidName(string? name);

    }
}
