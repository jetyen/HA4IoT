﻿namespace HA4IoT.Contracts.Hardware
{
    public interface IDevice
    {
        DeviceId Id { get; }

        //JsonObject HandleApiRequest(HttpMethod method, JsonObject request);
    }
}
