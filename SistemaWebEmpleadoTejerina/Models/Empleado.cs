using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaWebEmpleadoTejerina.Models
{
    public class Empleado
    {
        [Key]
        public int EmpleadoId { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string Apellido { get; set; }
        [Range(1000000, 100000000)]
        public int Dni { get; set; }
        //TODO Comprobar que Regular Expression sea correcta
        //Legajo debe ser dos letras AA y 5 numeros.
        [Required(ErrorMessage = "Campo Obligatorio")]
        [Column(TypeName ="Varchar")]
        [StringLength(7)]
        [RegularExpression("^AA[0-9]{5}", ErrorMessage = "Legajo es AA + cinco nùmeros")]
        public string Legajo { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        [Column(TypeName = "Varchar")]
        [StringLength(7)]
        public string Titulo { get; set; }
    }
}