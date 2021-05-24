using System;
using System.Threading.Tasks;
using HotChocolate.Types;
using MediatR;

namespace HotChocolate.Server.Template
{
    public class MutationType : ObjectType<Mutation>
    {
        protected override void Configure(IObjectTypeDescriptor<Mutation> descriptor) { }
    }

    public class Mutation
    {
        protected ISender Mediator { get; }

        public Mutation(ISender mediator)
        {
            Mediator = mediator;
        }

        public async Task<string> EchoMessage(EchoMessageType payload)
        {
            try
            {
                return await Mediator.Send(payload);
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
