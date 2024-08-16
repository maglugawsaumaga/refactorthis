using System;
using System.Collections.Generic;

namespace RefactorThis.Persistence
{
    public class Invoice
    {
        #region new code
        public decimal Amount { get; private set; }
        public decimal AmountPaid { get; private set; }
        public decimal TaxAmount { get; private set; }
        public string Reference { get; private set; }
        public List<Payment> Payments { get; private set; }
        public InvoiceType Type { get; private set; }

        public Invoice(decimal amount, decimal taxAmount, InvoiceType type)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Amount cannot be negative.", nameof(amount));
            }

            if (taxAmount < 0)
            {
                throw new ArgumentException("Tax amount cannot be negative.", nameof(taxAmount));
            }

            Amount = amount;
            TaxAmount = taxAmount;
            Type = type;
            Payments = new List<Payment>();
        }

        public void AddPayment(Payment payment)
        {
            if (payment == null)
            {
                throw new ArgumentNullException(nameof(payment));
            }

            Payments.Add(payment);
            AmountPaid += payment.Amount;
        }
        #endregion
        #region old code
        //private readonly InvoiceRepository _repository;
        //public Invoice( InvoiceRepository repository )
        //{
        //	_repository = repository;
        //}

        //public void Save( )
        //{
        //	_repository.SaveInvoice( this );
        //}

        //public decimal Amount { get; set; }
        //public decimal AmountPaid { get; set; }
        //public decimal TaxAmount { get; set; }
        //public List<Payment> Payments { get; set; }

        //public InvoiceType Type { get; set; }
        #endregion
    }

    public enum InvoiceType
    {
        Standard,
        Commercial
    }
}