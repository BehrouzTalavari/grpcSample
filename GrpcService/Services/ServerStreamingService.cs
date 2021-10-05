 
using System.Threading.Tasks; 
using Grpc.Core;
using GrpcService.Protos;

namespace GrpcService.Services
{
    public class ServerStreamingService : ServerSteaming.ServerSteamingBase
    {
        public override async Task SendMessage(ServerSteamingMessageRequest request, IServerStreamWriter<ServerSteamingMessageReply> responseStream, ServerCallContext context)
        {      
            var i = 0;
            while (!context.CancellationToken.IsCancellationRequested && i < 20)
            {
                await Task.Delay(500); // Gotta look busy

                var forecast = new Protos.ServerSteamingMessageReply
                {
                    Message = $"Message Stream {i++}"
                }; 
 
                await responseStream.WriteAsync(forecast);
            } 
        } 
    }
}
