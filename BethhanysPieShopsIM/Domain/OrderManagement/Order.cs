﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethhanysPieShopsIM.Domain.OrderManagement
{
    public class Order
    {
        public bool Fulfilled { get; set; } = false;
        public int Id { get; private set; }
        public List<OrderItem> OrderItems { get; }
        public DateTime OrderFulfilmentDate { get; private set; }

        public Order()
        {
            Id = new Random().Next(9999999);
            int numberofSeconds = new Random().Next(100);
            OrderFulfilmentDate = DateTime.Now.AddSeconds(numberofSeconds);

            OrderItems = new List<OrderItem>();
        }
        public string ShowOrderDetails()
        {
            StringBuilder orderDetails = new StringBuilder();

            orderDetails.AppendLine($"Order ID: {Id}");
            orderDetails.AppendLine($"Order fulfilment date: {OrderFulfilmentDate.ToShortTimeString()}");

            if (OrderItems != null)
            {
                foreach (OrderItem item in OrderItems)
                {
                    orderDetails.AppendLine();
                }
            }

            return orderDetails.ToString();
        }

    }
}
