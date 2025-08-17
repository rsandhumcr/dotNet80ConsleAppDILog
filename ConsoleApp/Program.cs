using ConsoleApp.Logger;
using ConsoleApp.Setup;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp;

internal class Program
{
    private static void Main(string[] args)
    {
        var host = SetupHost.CreateHost();
        var svc = ActivatorUtilities.CreateInstance<SampleLogger>(host.Services);
        svc.Run();
    }
}