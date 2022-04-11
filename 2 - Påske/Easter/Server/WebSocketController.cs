using System.Net.WebSockets;
using System.Text;
using Easter.Classes;
using Microsoft.AspNetCore.Mvc;

namespace Easter.Server;

[ApiController]
[Route("[controller]")]
public class WebSocketController : ControllerBase
{
    public static Game theGame = new();
    
    [HttpGet("/ws")]
    public async Task Get()
    {
        if (HttpContext.WebSockets.IsWebSocketRequest)
        {
            using var webSocket = await HttpContext.WebSockets.AcceptWebSocketAsync();

            if (!theGame.clients.Any())
            {
                theGame.clients.Add(webSocket);
            }
            else if (theGame.clients.Count == 1)
            {
                theGame.clients.Add(webSocket);
                theGame.startGame();
            }
        }
        else
        {
            HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
        }
    }
    
    private async Task Play(WebSocket webSocket)
    {
        var buffer = new byte[1024 * 4];
        var result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);

        while (!result.CloseStatus.HasValue)
        {
            result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
        }
        await webSocket.CloseAsync(result.CloseStatus.Value, result.CloseStatusDescription, CancellationToken.None);
        
        //clients.Remove(webSocket);
        theGame.endGame();
    }
}