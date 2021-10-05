using System;
using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcService;

namespace GRPCClient
{
    internal class Program
    {
        static async Task Main()
        {
            // The port number(5001) must match the port of the gRPC server.
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new UnaryService.UnaryServiceClient(channel);
            var reply = await client.SendMessageAsync(new UnaryMessageRequest() { Name = "UnaryService Type Client " });
            Console.WriteLine("UnaryService Type: " + reply.Message);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
