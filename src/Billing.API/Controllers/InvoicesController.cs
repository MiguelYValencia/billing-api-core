using Microsoft.AspNetCore.Mvc;
using Billing.Application.Interfaces;
using Billing.Domain.Entities;

namespace Billing.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvoicesController : ControllerBase
    {
        private readonly IInvoiceService _invoiceService;

        public InvoicesController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var invoices = await _invoiceService.GetInvoicesAsync();
            return Ok(invoices);
        }
    }
}
