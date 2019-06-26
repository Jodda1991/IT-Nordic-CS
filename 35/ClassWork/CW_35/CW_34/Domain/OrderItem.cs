using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CW_34.Domain
{
    public class OrderItem
    {
        public int OrderId { get; set; }

        public Product Product { get; set; }

        public int NumberOfItems { get; set; }
    }
}
