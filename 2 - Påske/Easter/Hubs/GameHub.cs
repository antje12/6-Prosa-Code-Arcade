using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.SignalR;

namespace Easter.Hubs;

public class GameHub : Hub
{
    public override async Task OnConnectedAsync()
    {
        var feature = Context.Features.Get<IHttpConnectionFeature>();
        await base.OnConnectedAsync();
    }
    
    public Task Move(int prevX, int prevY, int currentX, int currentY, string color)
    {
        return Clients.Others.SendAsync("move", prevX, prevY, currentX, currentY, color);
    }
    
    public override async Task OnDisconnectedAsync(Exception? exception)
    {
        var feature = Context.Features.Get<IHttpConnectionFeature>();
        //feature.RemoteIpAddress;
        
        await Groups.RemoveFromGroupAsync(Context.ConnectionId, "SignalR Users");
        
        await base.OnDisconnectedAsync(exception);
    }
}