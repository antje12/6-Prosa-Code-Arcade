using Easter.Classes;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.SignalR;

namespace Easter.Hubs;

public class GameHub : Hub
{
    private static Game theGame = new();

    public override async Task OnConnectedAsync()
    {
        var feature = Context.Features.Get<IHttpConnectionFeature>();
        var client = feature.ConnectionId;

        if (string.IsNullOrEmpty(theGame.player1))
        {
            theGame.player1 = client;
            theGame.startGame(Clients);
        }
        else if (string.IsNullOrEmpty(theGame.player2))
        {
            theGame.player2 = client;
            theGame.startGame(Clients);
        }

        await base.OnConnectedAsync();
    }

    public void Move(string message)
    {
        var feature = Context.Features.Get<IHttpConnectionFeature>();
        var client = feature.ConnectionId;

        if (message == "right")
        {
            if (theGame.player1 == client)
            {
                theGame.p1.moveRight();
            }
            else if (theGame.player2 == client)
            {
                theGame.p2.moveRight();
            }
        }
        else if (message == "left")
        {
            if (theGame.player1 == client)
            {
                theGame.p1.moveLeft();
            }
            else if (theGame.player2 == client)
            {
                theGame.p2.moveLeft();
            }
        }
    }

    public override async Task OnDisconnectedAsync(Exception? exception)
    {
        var feature = Context.Features.Get<IHttpConnectionFeature>();
        var client = feature.ConnectionId;

        if (theGame.player1 == client)
        {
            theGame.player1 = null;
            theGame.endGame();
        }
        else if (theGame.player2 == client)
        {
            theGame.player2 = null;
            theGame.endGame();
        }

        await base.OnDisconnectedAsync(exception);
    }
}