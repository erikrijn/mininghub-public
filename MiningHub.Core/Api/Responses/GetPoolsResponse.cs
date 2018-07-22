﻿using System.Collections.Generic;
using MiningHub.Core.Blockchain;
using MiningHub.Core.Configuration;
using MiningHub.Core.Mining;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MiningHub.Core.Api.Responses
{
    public class ApiCoinConfig
    {
        public string Type { get; set; }
        public string Algorithm { get; set; }
    }

    public class ApiPoolPaymentProcessingConfig
    {
        public bool Enabled { get; set; }
        public decimal MinimumPayment { get; set; } // in pool-base-currency (ie. Bitcoin, not Satoshis)
        public string PayoutScheme { get; set; }
        public JToken PayoutSchemeConfig { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> Extra { get; set; }
    }

    public partial class PoolInfo
    {
        // Configuration Properties directly mapping to PoolConfig (omitting security relevant fields)
        public string Id { get; set; }

        public ApiCoinConfig Coin { get; set; }
        public Dictionary<int, PoolEndpoint> Ports { get; set; }
        public ApiPoolPaymentProcessingConfig PaymentProcessing { get; set; }
        public PoolShareBasedBanningConfig ShareBasedBanning { get; set; }
        public int ClientConnectionTimeout { get; set; }
        public int JobRebroadcastTimeout { get; set; }
        public int BlockRefreshInterval { get; set; }
        public float PoolFeePercent { get; set; }
        public string Address { get; set; }
        public string AddressInfoLink { get; set; }

        // Stats
        public PoolStats PoolStats { get; set; }
        public BlockchainStats NetworkStats { get; set; }
        public MinerPerformanceStats[] TopMiners { get; set; }
        public decimal TotalPaid { get; set; }
    }

    public class GetPoolsResponse
    {
        public PoolInfo[] Pools { get; set; }
    }
}
