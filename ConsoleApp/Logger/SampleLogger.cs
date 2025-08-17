using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ConsoleApp.Logger;

public class SampleLogger : ISampleLogger
{
    private readonly IConfiguration _config;
    private readonly ILogger<SampleLogger> _log;

    public SampleLogger(ILogger<SampleLogger> log, IConfiguration config)
    {
        _log = log;
        _config = config;
    }

    public void Run()
    {
        for (var i = 0; i < _config.GetValue<int>("LoopTimes"); i++) _log.LogError("Loop number {runNumber}", i);
    }
}