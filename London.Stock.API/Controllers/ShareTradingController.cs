using London.Stock.API.DTO;
using London.Stock.Services;
using Microsoft.AspNetCore.Mvc;

namespace London.Stock.API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ShareTradingController: ControllerBase
    {
        private readonly IDataService _dataService;

        public ShareTradingController(
            IDataService dataService
        )
        {
            _dataService = dataService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateShareTradingAsync([FromBody] ShareTradingDto newShareTrade)
        {
            var newshareTradeModel = await this._dataService.CreateShareTradingAsync(newShareTrade.TickerSymbol, newShareTrade.SharePrice, newShareTrade.NumberOfShares, newShareTrade.BrokerId);
            return Ok(newshareTradeModel);
        }


        [HttpGet("{tickerSymbol}")]
        public async Task<IActionResult> GetShareBySymbolAsync(string tickerSymbol)
        {
            //TODO implement Data Service to query the db for current stock value
            return Ok();
        }

    }
}
