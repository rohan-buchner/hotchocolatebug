using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace HotChocolate.Server.Template
{
    public record EchoMessageType(string Message) : IRequest<string>
    {
        public class Handler : IRequestHandler<EchoMessageType, string>
        {
            public Task<string> Handle(EchoMessageType request, CancellationToken cancellationToken)
            {
                return Task.FromResult(request.Message);
            }
        }
    }
}