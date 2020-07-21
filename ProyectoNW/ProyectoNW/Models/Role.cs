using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoNW.Models
{
    public class Role
    {
        [Key]
        public int id { get; set; }

        public string UsuarioRoleKey { get; set; }

        public enum Rol
        {
            Empleados,
                Admin,
                ClienteExterno


        }
        public Rol RoleUser { get; set; }

    }
}