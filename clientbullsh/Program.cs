using Grpc.Net.Client;

await RunClient();

async Task RunClient()
{
    using var channel = GrpcChannel.ForAddress("http://localhost:6767");
    var client = new Protobufs.ServerCommsService.ServerCommsServiceClient(channel);
    var response = await client.HeartbeatAsync(new Protobufs.EmptyServerCommRequest());
    Console.WriteLine(response.Msg, response.IsHeartbeat);
}
