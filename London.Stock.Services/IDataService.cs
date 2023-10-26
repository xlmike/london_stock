using London.Stock.Data.Models;

namespace London.Stock.Services
{
    public interface IDataService
    {
        Task<ShareTrading> CreateShareTradingAsync(string tickerSymbol, decimal sharePrice, decimal numberOfShares, string brokerId);
    }
}
