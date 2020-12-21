using ExchangeRates.CbCurrencyAccessor;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ExchangeRates.API.Controllers
{
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private CurrencyAccessor accessor => new CurrencyAccessor();

        [Route("currencies")]
        [HttpGet]
        public async Task<IActionResult> GetCurrencies()
        {
            var dailyCurrencies = await accessor.GetDailyRates();
            var currencies = dailyCurrencies.Valute.Values;

            return Ok(currencies);
        }

        [Route("currency/{currencyId}")]
        [HttpGet]
        public async Task<IActionResult> GetCurrency(string currencyId)
        {
            var currency = await accessor.GetCurrency(currencyId);

            return Ok(currency);
        }
    }
}
