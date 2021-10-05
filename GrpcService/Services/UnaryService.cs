using System.Threading.Tasks;
using Grpc.Core; 

namespace GrpcService.Services
{
    public class UnaryService : UnaryType.UnaryTypeBase
    {
        public override Task<MessageReply> SendMessage(MessageRequest request, ServerCallContext context)
        {
            return Task.FromResult(new MessageReply
            {
                Message = "Hello " + request.Name
            });
        }
    }
}
