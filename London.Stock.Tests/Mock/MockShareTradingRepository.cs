
using London.Stock.Data.Models;

namespace London.Stock.Tests.Mock
{
    public class MockShareTradingRepository: IShareTradingRepository
    {
        private readonly List<ShareTrading> shareTradings = new List<ShareTrading>() {
             new ShareTrading() { Id = Guid.Parse("e6b990b1-82d2-4ed7-b1b5-5a5cf6277d1d"), TickerSymbol = "VOD:LN", SharePrice = 3.50M, NumberOfShares = 100.00M,  BrokerId = "BNXLND" }
        };


        public async Task<ShareTrading> CreateShareTradingAsync(string tickerSymbol, decimal sharePrice, decimal noOfShares, string brokerId) { 
            
            var newTrade = new ShareTrading() {
                Id = Guid.NewGuid(),
                TickerSymbol = tickerSymbol,
                SharePrice = sharePrice,
                NumberOfShares = noOfShares,
                BrokerId = brokerId
            };
            this.shareTradings.Add(newTrade);
            return newTrade;
        }

    }
}
