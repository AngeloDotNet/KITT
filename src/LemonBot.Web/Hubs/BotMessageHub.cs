﻿using Microsoft.AspNetCore.SignalR;

namespace LemonBot.Web.Hubs;

public class BotMessageHub : Hub
{
    private readonly ILogger<BotMessageHub> logger;

    public BotMessageHub(ILogger<BotMessageHub> logger)
    {
        this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public override Task OnConnectedAsync()
    {
        logger.LogInformation("Connection done");
        return base.OnConnectedAsync();
    }

    public override Task OnDisconnectedAsync(Exception? exception)
    {
        return base.OnDisconnectedAsync(exception);
    }

    public async Task SendOverlay(string resourceUrl)
    {
        await Clients.All.SendAsync("OverlayReceived", resourceUrl);
    }

    public async Task SendBotStart() => await Clients.All.SendAsync("BotStarted");

    public async Task SendUserJoin(string username)
        => await Clients.All.SendAsync("UserJoinReceived", username);

    public async Task SendUserLeft(string username)
        => await Clients.All.SendAsync("UserLeftReceived", username);

    public async Task SendNewUserSubscription(string subscriber)
        => await Clients.All.SendAsync("UserSubscriptionReceived");
}
