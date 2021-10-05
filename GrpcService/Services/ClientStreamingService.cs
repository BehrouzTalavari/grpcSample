using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Grpc.Core;
using GrpcService.Protos;

namespace GrpcService.Services
{
    public class ClientStreamingService:ClientSteaming.ClientSteamingBase
    {
        
        public override async Task<ClientSteamingMessageReply> SendMessage(IAsyncStreamReader<ClientSteamingMessageRequest> requestStream, ServerCallContext context)
        {
            var givenRequest =new List<ClientSteamingMessageRequest>();
            while (await requestStream.MoveNext())
            {
                var request = requestStream.Current;
                givenRequest.Add(request);
                Console.WriteLine(request.Name);
            }

            Console.WriteLine($"Server Get {givenRequest.Count}");
            return new ClientSteamingMessageReply()
            {
                Message = $"Server Reply: I got {givenRequest.Count} Message"
            };
        }
    }
}
