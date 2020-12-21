using ExchangeRates.CbCurrencyAccessor;
using ExchangeRates.CbCurrencyAccessor.Models;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace ExchangeRates.Tests
{
    public class CbCurrencyAccessorTests
    {
        IEnumerable<Currency> currenciesList;
        CurrencyAccessor accessor;

        [SetUp]
        public async Task Setup()
        {
            accessor = new CurrencyAccessor();
            currenciesList = (await accessor.GetDailyRates()).Valute.Values;
        }

        [Test]
        public async Task CanGetCurrencyById()
        {
            Currency currencyFromList = currenciesList.FirstOrDefault();

            Currency currencyFromAccessor = await accessor.GetCurrency(currencyFromList.Id);

            Assert.NotNull(currencyFromAccessor);
            Assert.AreEqual(currencyFromList, currencyFromAccessor);
        }
    }
}