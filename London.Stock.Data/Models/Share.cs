namespace London.Stock.Data.Models
{
    public class Share
    {
        public Guid Id { get; set; }

        public string TickerSymbol { get; set; }

        public decimal StockValue { get; set; } = 0.0M;
    }
}
