using System;


namespace Retail.Models.ViewModels
{
    public class OrderViewModel
    {

        //public Guid OrderId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        //public DateTime InvoiceDate { get; set; }
        public DateTime DeliveredDate { get; set; }

    }
}

