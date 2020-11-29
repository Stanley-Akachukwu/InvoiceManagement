using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TakeHome.Models.InvoiceViewModels;
using TakeHome.WebAPI.Data.Abstract;
using TakeHome.WebAPI.Data.Entities;

namespace TakeHome.WebAPI.Controllers
{
    [Route("/api/invoices")]
    [ApiController]
    public class InvoicesController : ControllerBase
    {
        private readonly IInvoiceRepository _invoiceRepository;
        public InvoicesController(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }
        [HttpGet]
        public async Task<ActionResult> GetInvoices()
        {
            try
            {
                return Ok(await _invoiceRepository.GetInvoices());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
        [HttpGet("{id:Guid}")]
        public async Task<ActionResult<Invoice>> GetInvoice(Guid id)
        {
            try
            {
                var result = await _invoiceRepository.GetInvoice(id);

                if (result == null)
                {
                    return NotFound();
                }

                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpPost]
        public async Task<ActionResult<InvoiceServiceResponse>> CreateInvoice(Invoice invoice)
        {
            var response = new InvoiceServiceResponse();

            try
            {
                if (invoice == null)
                {
                    response.ResponseCode = StatusCodes.Status422UnprocessableEntity;
                    response.ResponseMessage = "Invalid data supplied";
                    return response;
                }

                var inv = await _invoiceRepository.GetInvoiceByOrderNuber(invoice.OrderNumber);

                if (inv != null)
                {
                    response.ResponseCode = StatusCodes.Status409Conflict;
                    response.ResponseMessage = "Duplicate data is not allowed,Order number already in use.";
                    return response;
                }

                var createdInvoice = await _invoiceRepository.AddInvoice(invoice);
                response.ResponseCode = StatusCodes.Status201Created;
                response.ResponseMessage = createdInvoice.Description + " was created successfully";
                return response;
            }
            catch (Exception exp)
            {
                response.ResponseCode = StatusCodes.Status500InternalServerError;
                response.ResponseMessage = "Internal server error occurred "+exp.StackTrace;
                return response;
            }
        }

        [HttpPut]
        public async Task<ActionResult<Invoice>> UpdateInvoice(Invoice invoice)
        {
            try
            {
                var InvoiceToUpdate = await _invoiceRepository.GetInvoice(invoice.InvoiceNumber);

                if (InvoiceToUpdate == null)
                {
                    return NotFound($"Invoice with Id = {invoice.InvoiceNumber} not found");
                }

                return await _invoiceRepository.UpdateInvoice(invoice);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating data");
            }
        }

        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult<Invoice>> DeleteInvoice(Guid id)
        {
            try
            {
                var InvoiceToDelete = await _invoiceRepository.GetInvoice(id);

                if (InvoiceToDelete == null)
                {
                    return NotFound($"Invoice with Id = {id} not found");
                }

                return await _invoiceRepository.DeleteInvoice(id);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting data");
            }
        }
    }
}
