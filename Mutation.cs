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
        public async Task<string> EchoMessage(
             [Service] ISender mediator, 
             EchoMessageType payload)
        {
            try
            {
                return await mediator.Send(payload);
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
