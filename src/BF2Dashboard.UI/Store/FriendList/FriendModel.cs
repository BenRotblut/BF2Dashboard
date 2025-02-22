﻿using BF2Dashboard.Domain.BattlefieldApi;

namespace BF2Dashboard.UI.Store.FriendList;

public class FriendModel
{
    public bool IsOnline { get; set; }

    public string DisplayName { get; private init; }

    public override string ToString() => DisplayName;

    public Player? Player { get; private init; }

    public ServerInfoModel? ServerInfo { get; private init; }

    public static FriendModel CreateOnlineFriend(Player player, Server server)
    {
        return new FriendModel()
        {
            IsOnline = true,
            DisplayName = player.FullName,
            Player = player,
            ServerInfo = ServerInfoModel.FromServer(server),
        };
    }

    public static FriendModel CreateOfflineFriend(string displayName)
    {
        return new FriendModel()
        {
            IsOnline = false,
            DisplayName = displayName,
            Player = null,
            ServerInfo = null,
        };
    }

    private FriendModel()
    {
    }
}