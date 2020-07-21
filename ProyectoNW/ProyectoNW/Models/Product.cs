using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProyectoNW.Models
{
    public class Product
    {

        [Key]
        [Display(Name = "Codigo")]
        public int ProductId { get; set; }
//-----------------------------------------------------------------------------
        [Display(Name = "Nombre")]
        [Required]
        //[MaxLength(50, ErrorMessage = "El maximo de caracteres es 50")]
      //  [MinLength(2, ErrorMessage = "El minimo de caracteres es 2")]
        public string ProductNombre { get; set; }
     //   ------------------------------------------------------------------------
        [Display(Name = "imagen")]
        [Required]
        //[MaxLength(50, ErrorMessage = "El maximo de caracteres es 50")]
        //  [MinLength(2, ErrorMessage = "El minimo de caracteres es 2")]
        public string ProductImage { get; set; }
        //--------------------------------------------------------------------------------
        [Display(Name = "Producto Descripcion")]
        [Required]
        //[MaxLength(50, ErrorMessage = "El maximo de caracteres es 50")]
        //  [MinLength(2, ErrorMessage = "El minimo de caracteres es 2")]
        public string ProductDescription { get; set; }
//---------------------------------------------------------------------------
        [Display(Name = "Cantidad")]
        //   [Required(ErrorMessage = "El número es obligatorio")]

        public int ProductQuantity { get; set; }
//--------------------------------------------------------------------

        [Display(Name = "Precio")]
     //   [Required(ErrorMessage = "El número es obligatorio")]

        [DataType(DataType.Currency)]

        public Decimal ProductPrice { get; set; }

//--------------------------------------------------------------------------

        [Display(Name = "Fecha de Compra")]
        [Required]
        [DataType(DataType.Date, ErrorMessage = "el formato campo debe ser fecha")]
        public DateTime ProductElaboration { get; set; }
//------------------------------------------------------------------

        [Display(Name = "Fecha de Expiracion")]
        [Required]
        [DataType(DataType.Date, ErrorMessage = "el formato campo debe ser fecha")]
        public DateTime ProductExpiration { get; set; }

//-------------------FORANEAS--------------------------/

//--------------------CATEGORIA---------------------------------------------------
        [Display(Name = "Categoria")]
        public int CategoryKey { get; set; }


        [ForeignKey("CategoryKey")]
        public Category Category { get; set; }
//------------------------PROVEEDOR-------------------------------------
        [Display(Name = "Proveedor")]
        public int ProviderKey { get; set; }


        [ForeignKey("ProviderKey")]
        public Provider Provider { get; set; }

        // public virtual ICollection<SaleDetails> SaleDetails { get; set; }
    }
}