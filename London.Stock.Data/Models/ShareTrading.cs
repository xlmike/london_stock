namespace London.Stock.Data.Models
{
    public class ShareTradings
    {
        public Guid Id { get; set; }

        public Guid SharesId { get; set; }

        public decimal SharesValue { get; set; }

        public decimal NumbersOfShares { get; set; }

        public Guid BrokerId { get; set; }
    }
}