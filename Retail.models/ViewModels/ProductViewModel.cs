using System;


namespace Retail.ViewModels
{
    public class ProductViewModel
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public int AvailableQuantity { get; set; }
    }
}
