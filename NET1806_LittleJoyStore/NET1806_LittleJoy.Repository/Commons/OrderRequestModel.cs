﻿namespace NET1806_LittleJoy.API.ViewModels.RequestModels
{
    public class OrderRequestModel
    {
        public int UserId { get; set; }

        public int TotalPrice { get; set; }

        public string Address { get; set; }

        public string? Note { get; set; }

        public int? AmountDiscount { get; set; }

        public string PaymentMethod { get; set; }

        public List<ProductOrder> ProductOrders { get; set; }
    }

    public class ProductOrder
    {
        public int Id { get; set; }

        public int Quantity { get; set; }
    }
}
