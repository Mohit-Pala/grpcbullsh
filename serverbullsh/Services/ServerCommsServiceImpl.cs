using Grpc.Core;
using Protobufs;

namespace Serverbullsh.Services;

public class ServerCommsServiceImpl : ServerCommsService.ServerCommsServiceBase
{
    public override Task<MessageServerCommResponse> Heartbeat(EmptyServerCommRequest request, ServerCallContext context)
    {
        return Task.FromResult(new MessageServerCommResponse { Msg = "heartbeat - childish gambino, the songs fire", IsHeartbeat = "true" });
    }
}
