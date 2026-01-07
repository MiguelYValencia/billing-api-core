using Billing.Domain.Entities;

namespace Billing.Application.Interfaces
{
    public interface IInvoiceService
    {
        Task<IEnumerable<Invoice>> GetInvoicesAsync();
        Task<Invoice> CreateInvoiceAsync(Invoice invoice);
    }
}
