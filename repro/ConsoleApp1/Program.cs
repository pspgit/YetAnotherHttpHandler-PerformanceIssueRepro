

using System.Diagnostics;
using Cysharp.Net.Http;
using Grpc.Net.Client;
using Helloworld;


// Run Server App 
// https://hub.docker.com/r/tobegit3hub/grpc-helloworld
// docker run -d -p 50051:50051 tobegit3hub/grpc-helloworld
//
// .proto source:
// https://github.com/grpc/grpc/blob/master/examples/protos/helloworld.proto

const string ServerAddress = "http://<put remote server ip here>:50051";
const int Iterations = 10;
const int DelayBetweenCalls = 300;

try
{
    var sw = new Stopwatch();
    
    Console.WriteLine("YetAnotherHttpHandler");
    using (var yetAnotherChannel = GrpcChannel.ForAddress(ServerAddress,
               new GrpcChannelOptions()
               {
                   HttpHandler = new YetAnotherHttpHandler()
                   {
                       Http2Only = true,
                       SkipCertificateVerification = true,
                   }
               }))
    {
        var yetAnotherClient = new Greeter.GreeterClient(yetAnotherChannel);
        
        for (int i = 0; i < Iterations; i++)
        {
            sw.Start();
            var reply = await yetAnotherClient.SayHelloAsync(
                new HelloRequest {Name = "GreeterClient"});

            sw.Stop();

            Console.WriteLine("Yet Greeting: " + reply.Message + " " + sw.ElapsedMilliseconds);
            sw.Reset();

            await Task.Delay(DelayBetweenCalls);
        }
    }

    Console.WriteLine();
    Console.WriteLine(".NET HttpHandler");
    
    using (var regularChannel = GrpcChannel.ForAddress(ServerAddress))
    {
        var regularClient = new Greeter.GreeterClient(regularChannel);

        for (int i = 0; i < Iterations; i++)
        {
            sw.Start();
            var reply = await regularClient.SayHelloAsync(
                new HelloRequest {Name = "GreeterClient"});

            sw.Stop();

            Console.WriteLine(".NET Greeting: " + reply.Message + " " + sw.ElapsedMilliseconds);
            sw.Reset();

            await Task.Delay(DelayBetweenCalls);
        }
    }
}
catch (Exception e)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(e);
    Console.ResetColor();
}


Console.ReadKey();
