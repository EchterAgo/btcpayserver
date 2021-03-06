﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BTCPayServer.Payments.Lightning.CLightning;
using NBitcoin;

namespace BTCPayServer.Tests
{
    public class LightningDTester
    {
        ServerTester parent;
        public LightningDTester(ServerTester parent, string environmentName, string defaultRPC, string defaultHost, Network network)
        {
            this.parent = parent;
            RPC = new CLightningRPCClient(new Uri(parent.GetEnvironment(environmentName, defaultRPC)), network);
        }

        public CLightningRPCClient RPC { get; }
        public string P2PHost { get; }
        
    }
}
