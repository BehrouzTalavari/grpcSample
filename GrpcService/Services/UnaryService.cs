using System.Dynamic;
using System.Threading.Tasks;

using Grpc.Core; 

namespace GrpcService.Services
{
    public class UnaryService : GrpcService.UnaryService.UnaryServiceBase
    {
        public override Task<UnaryMessageReply> SendMessage(UnaryMessageRequest request, ServerCallContext context)
        {
            return Task.FromResult(new UnaryMessageReply
            {
                Message = "Hello " + request.Name
            });
        }
    }
}
