using System;
using System.Collections.Generic;
using System.Text;

namespace ExchangeRates.CbCurrencyAccessor.Models
{
    /// <summary>
    /// Модель ответа ежедневных данных курса валют от ЦБ
    /// </summary>
    public class CbDaily
    {
        public DateTime Date { get; set; }
        public DateTime PreviousDate { get; set; }
        public string PreviousUrl { get; set; }
        public DateTime Timestamp { get; set; }
        public Dictionary<string, Currency> Valute { get; set; }
    }
}
