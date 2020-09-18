using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace N00020449CRUD.Models
{
    public class Cuenta
    {
        [MinLength(2)]
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string FechaNacimiento { get; set; }
        public string DNI { get; set; }
        public string Sexo { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public string CorreoElectronico { get; set; }
        public string UserName { get; set; }
        public string Contrasenia { get; set; }

        
        
    }
}

