using System;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using GrpcService.Protos;

namespace GrpcService.Services
{
    public class ServerStreamingService : ServerSteaming.ServerSteamingBase
    {
        public override async Task SendMessage(Protos.MessageRequest request, IServerStreamWriter<Protos.MessageReply> responseStream, ServerCallContext context)
        {
            var i = 0;
            while (!context.CancellationToken.IsCancellationRequested && i < 20)
            {
                await Task.Delay(500); // Gotta look busy

                var forecast = new Protos.MessageReply
                {
                    Message = $"Message Stream {i++}"
                }; 
 
                await responseStream.WriteAsync(forecast);
            }
        }
    }
}
