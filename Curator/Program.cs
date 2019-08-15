using System;
using System.Threading.Tasks;
using McMaster.Extensions.CommandLineUtils;

namespace Curator
{
    class Program
    {
        static Task<int> Main(string[] args) => CommandLineApplication.ExecuteAsync<CuratorCommand>(args);
    }
}
