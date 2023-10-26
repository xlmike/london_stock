using London.Stock.Data.Models;

namespace London.Stock.Services
{
    public interface IShareTradingRepository
    {
        Task<ShareTrading> CreateShareTradingAsync(string tickerSymbol, decimal sharePrice, decimal noOfShares, string brokerId);
    }
}
