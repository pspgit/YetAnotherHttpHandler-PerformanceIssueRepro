using Cysharp.Net.Http;
using Grpc.Net.Client;
using GrpcService1;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    internal class Program
    {
        // TODO: Put server address / port HERE
        //const string ServerAddress = "http://localhost:5034";
        const string ServerAddress = "http://192.168.100.14:32774";
        const int RequestDelayMs = 10;

        static async Task Main(string[] args)
        {

            using var regularChannel = GrpcChannel.ForAddress(ServerAddress);
            using var yetAnotherChannel = GrpcChannel.ForAddress(ServerAddress,
               new GrpcChannelOptions()
               {
                   HttpHandler = new YetAnotherHttpHandler()
                   {
                       Http2Only = true,
                       SkipCertificateVerification = true,
                   }
               });

            var yetAnotherClient = new Greeter.GreeterClient(yetAnotherChannel);
            var regularClient = new Greeter.GreeterClient(regularChannel);

            var requestData = new HelloRequest()
            {
                Name = "Test",
                Data = GetRandomString(1000)
            };

            for (int i = 0; i < 10000; i++)
            {
                var yetRequest = yetAnotherClient.SayHelloYetAsync(requestData);
                var regularRequest = regularClient.SayHelloRegularAsync(requestData);

                if (i % 10 == 0)
                    Console.WriteLine($"Sending request: {i}");

                await Task.WhenAll(yetRequest.ResponseAsync, regularRequest.ResponseAsync);
                await Task.Delay(RequestDelayMs);                
            }
        }

        private static string GetRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz";

            return new string(Enumerable.Range(1, length).Select(_ => chars[Random.Shared.Next(chars.Length)]).ToArray());
        }
    }
}

public class NativeLibraryResolver
{
    [ModuleInitializer]
    public static void Initialize()
    {
        NativeLibrary.SetDllImportResolver(typeof(Cysharp.Net.Http.YetAnotherHttpHandler).Assembly, (name, assembly, path) =>
        {
            var ext = "";
            var prefix = "";
            var platform = "";

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                platform = "win";
                prefix = "";
                ext = ".dll";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                platform = "osx";
                prefix = "lib";
                ext = ".dylib";
            }
            else
            {
                platform = "linux";
                prefix = "lib";
                ext = ".so";
            }

            var arch = RuntimeInformation.OSArchitecture switch
            {
                Architecture.Arm64 => "arm64",
                Architecture.X64 => "x64",
                Architecture.X86 => "x86",
                _ => throw new NotSupportedException(),
            };

            string filePath = Path.Combine($"runtimes/{platform}-{arch}/native/{prefix}{name}{ext}");
            if (!File.Exists(filePath))
                filePath = $"bin/Debug/net8.0/{filePath}";

            return NativeLibrary.Load(filePath);
        });
    }
}
