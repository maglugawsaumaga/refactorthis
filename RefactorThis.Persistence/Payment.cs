using System;

namespace RefactorThis.Persistence
{
    public class Payment
    {
        #region new code
        public decimal Amount { get; private set; }
        public string Reference { get; private set; }

        public Payment(decimal amount, string reference)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount must be greater than zero.", nameof(amount));
            }

            if (string.IsNullOrWhiteSpace(reference))
            {
                throw new ArgumentException("Reference cannot be null or empty.", nameof(reference));
            }

            Amount = amount;
            Reference = reference;
        }
        #endregion
        #region old code
        //      public decimal Amount { get; set; }
        //public string Reference { get; set; }
        #endregion
    }
}