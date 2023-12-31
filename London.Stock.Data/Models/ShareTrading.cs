﻿namespace London.Stock.Data.Models
{
    public class ShareTrading
    {
        public Guid Id { get; set; }

        public string TickerSymbol { get; set; }

        public decimal SharePrice { get; set; }

        public decimal NumberOfShares { get; set; }

        public string BrokerId { get; set; }
    }
}