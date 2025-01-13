using GrpcService1.Services;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace GrpcService1
{
    public class Program
    {
        private const int MeasureRequestCount = 100;
        private static ConcurrentBag<double> _regularTimes = new();
        private static ConcurrentBag<double> _yetTimes = new();

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddGrpc();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            app.MapGrpcService<GreeterService>();
            app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");
            
            app.Use(async (context, next) =>
            {
                // MiddleWare to measure request processing performance

                var sw = new Stopwatch();
                sw.Start();

                await next();

                sw.Stop();

                if (context.Request.Path.HasValue)
                {
                    ConcurrentBag<double> bag;
                    string path = context.Request.Path.Value;

                    if (path.Contains(nameof(GreeterService.SayHelloRegular)))
                        bag = _regularTimes;
                    else if (path.Contains(nameof(GreeterService.SayHelloYet)))
                        bag = _yetTimes;
                    else
                        return;

                    bag.Add(sw.Elapsed.TotalMilliseconds);

                    if (bag.Count >= MeasureRequestCount)
                    {                        
                        Console.WriteLine($">>>>>>>>>>>>>>>\n>> Avg: {path}: {(bag.Sum() / bag.Count):0.000}ms");
                        bag.Clear();
                    }
                }
            });

            app.Run();
        }
    }
}