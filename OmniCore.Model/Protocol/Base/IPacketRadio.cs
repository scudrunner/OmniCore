﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OmniCore.Model.Protocol.Base
{
    public interface IPacketRadio
    {
        Task Initialize();

        Task SetLowTx();

        Task SetNormalTx();

        Task SetHighTx();

        Task<byte[]> SendPacketAndGetPacket(byte[] packetData);

        Task<byte[]> SendPacketAndExpectSilence(byte[] packetData);

        Task<byte[]> GetPacket(long timeout);
    }
}
