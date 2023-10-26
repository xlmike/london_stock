using London.Stock.API.Controllers;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace London.Stock.Tests
{
    public class ShareTradingControllerTest
    {
        private readonly IShareTradingRepository _shareTradingRepository;

        public ShareTradingControllerTest(IShareTradingRepository shareTradingRepository) {

            _shareTradingRepository = shareTradingRepository;
        }


        [Fact]
        public async Task CreateShouldReturn201()
        {
            var dataService = new DataService(
                _shareTradingRepository
            );

            var controller = new ShareTradingController(dataService);

            var tradingGuid = Guid.Parse("e6b990b1-82d2-4ed7-b1b5-5a5cf6277d1d");
            var response = await controller.CreateShareTradingAsync( new API.DTO.ShareTradingDto() { 
                       TickerSymbol = "XOD:L", 
                       SharePrice = 23.50M,
                       NumberOfShares = 500.00M,
                       BrokerId = "BNXLND"
                }
            );

            Assert.Equal(201, ((IStatusCodeActionResult)response).StatusCode);

        }
    }
}
