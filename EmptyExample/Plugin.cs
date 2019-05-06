using System;
using System.Threading;
using System.Threading.Tasks;
using HomeCTRL.Plugin;

namespace Example.Plugin.EmptyExample
{
    public class Plugin : IPlugin
    {
        public async Task<bool> Startup()
        {
            Console.WriteLine("TESSSTTTTT");

            return await Task.FromResult<bool>(true);
        }

        public void Dispose()
        {
            // do nothing
        }
    }
}
