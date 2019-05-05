using System;
using System.Threading;
using System.Threading.Tasks;

namespace HomeCTRL.Plugin.EmptyExample
{
    public class Plugin : IPlugin
    {
        public async Task<bool> Startup()
        {
            Console.WriteLine("TESSSTTTTT");

            return await Task.FromResult<bool>(true);
        }
    }
}
