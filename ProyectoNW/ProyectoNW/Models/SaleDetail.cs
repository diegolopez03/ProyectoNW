using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProyectoNW.Models
{
    public class SaleDetail
    {
        public int SaleDetailKey { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        public int SaleDetailQuantity { get; set; }

        public decimal SaleDetailSubTotal { get; set; }

        public int SaleKey { get; set; }

        [ForeignKey("SaleKey")]
        public Sale Sale { get; set; }
    }
}