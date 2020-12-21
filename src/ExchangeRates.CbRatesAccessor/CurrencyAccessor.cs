using ExchangeRates.CbCurrencyAccessor.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace ExchangeRates.CbCurrencyAccessor
{
    /// <summary>
    /// Класс для вызова API ЦБ
    /// </summary>
    public class CurrencyAccessor
    {
        private const string CB_URL = "https://www.cbr-xml-daily.ru/daily_json.js";

        /// <summary>
        /// Получение ежедневной иформации по валютам ЦБ
        /// </summary>
        /// <returns></returns>
        public async Task<CbDaily> GetDailyRates()
        {
            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync("https://www.cbr-xml-daily.ru/daily_json.js");

            string currenciesAsString = await response.Content.ReadAsStringAsync();

            CbDaily currencies = JsonConvert.DeserializeObject<CbDaily>(currenciesAsString);

            return currencies;
        }

        /// <summary>
        /// Получение информации по
        /// </summary>
        /// <param name="currencyId"></param>
        /// <returns></returns>
        public async Task<Currency> GetCurrency(string currencyId)
        {
            CbDaily currencies = await GetDailyRates();

            Currency currency = currencies.Valute.Values.Where(c => c.Id == currencyId).FirstOrDefault();

            return currency;
        }
    }
}
