using System;
using System.Collections.Generic;
using System.Text;

namespace ExchangeRates.CbCurrencyAccessor.Models
{
    /// <summary>
    /// Модель курса
    /// </summary>
    public class Currency
    {
        public string Id { get; set; }
        public int NumCode { get; set; }
        public string CharCode { get; set; }
        public int Nominal { get; set; }
        public decimal Value { get; set; }
        public decimal Previous { get; set; }

        public override bool Equals(object obj)
        {
            if(obj as Currency != null)
            {
                Currency objectToCompare = (Currency)obj;

                return (Id == objectToCompare.Id &&
                    Id == objectToCompare.Id &&
                    NumCode == objectToCompare.NumCode &&
                    CharCode == objectToCompare.CharCode &&
                    Nominal == objectToCompare.Nominal &&
                    Value == objectToCompare.Value &&
                    Previous == objectToCompare.Previous);
            }

            return false;
        }
    }
}
