﻿using System;

namespace MiningHub.Core.Persistence.Postgres.Entities
{
    public class Balance
    {
        public string PoolId { get; set; }
        public string Coin { get; set; }
        public string Address { get; set; }
        public decimal Amount { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
