﻿namespace Cobra.Server.Interfaces
{
    public interface ISteamService
    {
        public Task<bool> AuthenticateUser(byte[] authTicketDataBytes, ulong steamId);
    }
}