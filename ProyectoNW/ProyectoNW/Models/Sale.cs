using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProyectoNW.Models
{
    public class Sale
    {
        public int SaleKey { get; set; }

        public DateTime SaleDate { get; set; }

        public string  SaleAddress { get; set; }
        public int ClientKey { get; set; }

        [ForeignKey("ClienteKey")]

        public Client Client { get; set; }

        public virtual ICollection<SaleDetail> SaleDetail { get; set; }


    }
}