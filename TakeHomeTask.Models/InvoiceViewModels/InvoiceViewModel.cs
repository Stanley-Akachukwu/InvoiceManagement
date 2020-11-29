using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TakeHome.Models.InvoiceViewModels
{
    public class InvoiceViewModel
    {
        public Guid InvoiceNumber { get; set; }
        [Required(ErrorMessage = "Description must be provided")]
        [StringLength(50)]
        public string Description { get; set; }
        [Required(ErrorMessage = "Amount must be provided")]
        public decimal Amount { get; set; }
        public DateTime InvoiceDate { get; set; } 
        public DateTime DeliveryDate { get; set; }
        public DateTime SettleDate { get; set; }
        [Required(ErrorMessage = "Select vat")]
        public string InvoiceVat { get; set; } 
        [Required(ErrorMessage = "Select currency")]
        public string Currency { get; set; } 
        [Required(ErrorMessage = "Select exchange rate")]
        public string ExchangeRate { get; set; } 
        [Required(ErrorMessage = "Client name must be provided")]
        public string Client { get; set; } = "Select client";
        [Required(ErrorMessage = "Order number must be provided")]
        [StringLength(50)]
        public string OrderNumber { get; set; }
        [StringLength(50)]
        public string SalesAgent { get; set; }
    }
}

