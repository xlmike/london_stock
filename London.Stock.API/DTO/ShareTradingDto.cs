namespace London.Stock.API.DTO
{
    public class ShareTradingDto
    {
        public string TickerSymbol { get; set; }

        public decimal SharePrice { get; set; }

        public decimal NumberOfShares { get; set; }

        public string BrokerId { get; set; }

    }
}
