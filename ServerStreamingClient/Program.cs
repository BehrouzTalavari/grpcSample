using System;
using System.Threading.Tasks;

using Grpc.Core;
using Grpc.Net.Client;
using GrpcService.Protos;

namespace ServerStreamingClient
{
    internal class Program
    {
        static async Task Main()
        { 
            // The port number(5001) must match the port of the gRPC server.
            using var channel = GrpcChannel.ForAddress("https://localhost:5001"); 
            var client = new ServerSteaming.ServerSteamingClient(channel);
            using var call = client.SendMessage(new ServerSteamingMessageRequest() { Name = "Server Streaming Sample" });

            while (await call.ResponseStream.MoveNext())
            {
                Console.WriteLine("Server Streaming Sample: " + call.ResponseStream.Current.Message);
            }
        }
    }
}
