using System.ComponentModel.DataAnnotations;

namespace L01P022020PM605.Models
{
    public class alumnos
    {
        [Key]
        [Display(Name = "id de alumno")]
        public int id { get; set; }

        [Display(Name = "Codigo")]
        [Required(ErrorMessage = "El codigo No es opcional")]
        public string codigo { get; set; }

        [Display(Name = "Nombre de alumno")]
        [Required(ErrorMessage = "El nombre de la marca No es opcional")]
        public string nombre { get; set; }

        [Display(Name = "Apellido de alumno")]
        [Required(ErrorMessage = "El apellido No es opcional")]
        public string apellidos { get; set;}

        [Display(Name = "Dui")]
        [Required(ErrorMessage = "El dui No es opcional")]
        public int dui {  get; set;}

        [Display(Name = "Estado")]
        [Required(ErrorMessage = "El estado No es opcional")]
        public int estado {  get; set;}
    }
}
