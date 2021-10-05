using System;
using System.Threading.Tasks;

using Grpc.Net.Client;

using GrpcService.Protos;

namespace GRPCClientStreaming
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // The port number(5001) must match the port of the gRPC server.
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new ClientSteaming.ClientSteamingClient(channel);

            using var messageRequest = client.SendMessage();

            foreach (var message in new[] { "Behrouz", "Shakib", "Morteza", "Malek", "Ashkan", "MohammadReza" })
            {
                if (messageRequest != null)
                    await messageRequest.RequestStream.WriteAsync(new ClientSteamingMessageRequest() { Name = message });
            }

            await messageRequest.RequestStream.CompleteAsync();

            var response = await messageRequest.ResponseAsync;

            Console.WriteLine(response.Message);
            Console.ReadKey();
        }
    }
}
