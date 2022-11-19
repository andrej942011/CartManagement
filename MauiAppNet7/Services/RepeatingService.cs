using System.Diagnostics;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace MauiAppNet7.Services;

public class RepeatingSerive : BackgroundService
{
    public RepeatingSerive()
    {
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            Debug.WriteLine(DateTime.Now);
            await Task.Delay(1000, stoppingToken);
        }
    }
}