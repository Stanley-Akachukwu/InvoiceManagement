using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TakeHome.WebAPI.Data.Entities
{
    public class Invoice
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
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
        [StringLength(20)]
        public string InvoiceVat { get; set; }
        [Required(ErrorMessage = "Select currency")]
        [StringLength(10)]
        public string Currency { get; set; }
        [Required(ErrorMessage = "Select exchange rate")]
        [StringLength(20)]
        public string ExchangeRate { get; set; }
        [Required(ErrorMessage = "Client name must be provided")]
        [StringLength(50)]
        public string Client { get; set; }
        [Required(ErrorMessage = "Order number must be provided")]
        [StringLength(50)]
        public string OrderNumber { get; set; }
        [StringLength(50)]
        public string SalesAgent { get; set; }
    }
}

 