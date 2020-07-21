using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoNW.Models
{
    public class Provider
    {
        [Key]
        [Display(Name = "Codigo")]
        public int ProviderKey { get; set; }
        //--------------------------------------------------------------------
        [Display(Name = "Nombre")]
        [Required]
        [MaxLength(50, ErrorMessage = "El maximo de caracteres es 50")]
        public string ProviderName { get; set; }
        //------------------------------------------------------------------
        [Display(Name = "Contacto")]
        [MaxLength(50, ErrorMessage = "El maximo de caracteres es 50")]
        public string ProviderContact { get; set; }

        public virtual ICollection<Product> Products { get; set; }


    }
}