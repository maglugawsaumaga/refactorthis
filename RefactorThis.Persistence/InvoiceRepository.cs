using System.Collections.Generic;

namespace RefactorThis.Persistence
{
    #region new codde
    public interface IInvoiceRepository
    {
        Invoice GetInvoice(string reference);
        void SaveInvoice(Invoice invoice);
        void AddInvoice(Invoice invoice);
    }

    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly Dictionary<string, Invoice> _invoices = new Dictionary<string, Invoice>();

        public Invoice GetInvoice(string reference)
        {
            _invoices.TryGetValue(reference, out var invoice);
            return invoice;
        }

        public void SaveInvoice(Invoice invoice)
        {
            // Simulate saving to a database
            if (_invoices.ContainsKey(invoice.Reference))
            {
                _invoices[invoice.Reference] = invoice;
            }
            else
            {
                _invoices.Add(invoice.Reference, invoice);
            }
        }

        public void AddInvoice(Invoice invoice)
        {
            if (!_invoices.ContainsKey(invoice.Reference))
            {
                _invoices.Add(invoice.Reference, invoice);
            }
        }
    }
    #endregion
    #region old code
    //   public class InvoiceRepository
    //{
    //	private Invoice _invoice;

    //	public Invoice GetInvoice( string reference )
    //	{
    //		return _invoice;
    //	}

    //	public void SaveInvoice( Invoice invoice )
    //	{
    //		//saves the invoice to the database
    //	}

    //	public void Add( Invoice invoice )
    //	{
    //		_invoice = invoice;
    //	}
    //}
    #endregion
}