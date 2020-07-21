using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoNW.Models
{
    public class Client
    {

        [Key]
        [Display(Name = "Codigo")]
        public int ClienteKey { get; set; }
        //--------------------------------
        [Display(Name = "Name")]
        [Required]
        [MaxLength(50, ErrorMessage = "El maximo de caracteres es 50")]
        [MinLength(2, ErrorMessage = "El minimo de caracteres es 50")]
        public string ClientName { get; set; }
        //-------------------------------------------------
        [Display(Name = "Telefono")]
        [DataType(DataType.PhoneNumber)]
        public string ClientPhone { get; set; }
        //-----------------------------------------------------
        [Display(Name = "Genero")]
        [Required]
        [MaxLength(20, ErrorMessage = "El maximo de caracteres es 300")]
        [MinLength(5, ErrorMessage = "El minimo de caracteres es 5")]
        public string ClientGender { get; set; }
        //-----------------------------------------------------------------------------------
        [Display(Name = "Direccion")]
        [Required]
        [MaxLength(50, ErrorMessage = "El maximo de caracteres es 50")]
        [MinLength(5, ErrorMessage = "El minimo de caracteres es 5")]
        public string ClientAddress { get; set; }

    }
}