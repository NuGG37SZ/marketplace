﻿namespace OrderService.View
{
    public class OrderProductView
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public int ProductSizesId { get; set; }

        public int UserId { get; set; }

        public int Count { get; set; }
    }
}
