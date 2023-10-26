using London.Stock.Data.Models;


namespace London.Stock.Services
{
    public class DataService: IDataService
    {
        private readonly IShareTradingRepository _shareTradingRepository;
        public DataService(IShareTradingRepository shareTradingRepository) {
            _shareTradingRepository = shareTradingRepository;
        }

        public async Task<ShareTrading> CreateShareTradingAsync(string tickerSymbol, decimal sharePrice, decimal numberOfShares, string brokerId) {

            return await _shareTradingRepository.CreateShareTradingAsync( 
               tickerSymbol,
               sharePrice,
               numberOfShares,
               brokerId
           );

        }

    }
}
