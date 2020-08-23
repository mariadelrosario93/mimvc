using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace pruebamvc.Models
{
    public class Empleados
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name="Id:")]
        public int Id { set; get; }
        [Required(ErrorMessage ="Introduzca su nombre")]
        [Display (Name ="Primer nombre:")]
        public string Primernombre { set; get; }
        [Display(Name ="Segundo nombre:")]
        public String Segundonombre { set; get; }
        [Display(Name ="Apellido paterno:")]
        public string Apellidopaterno { set; get; }
        [Display(Name ="Apellido materno:")]
        public string Apellidomaterno { set; get; }
        [Display(Name ="Fecha de Nacimiento:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        public DateTime Fechanacimiento { set; get; }
        [Display(Name ="Sueldo:")]
        [DataType(DataType.Currency)]
        public Decimal Sueldo { set; get; }
        [Display(Name ="Activo:")]
        public Boolean Activo { set; get; }

    }
}