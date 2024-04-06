using System.ComponentModel.DataAnnotations;

namespace L01P022020PM605.Models
{
    public class departamentos
    {
        [Key]
        [Display(Name = "id de departamento")]
        public int id { get; set; }
        [Display(Name = "Departamento")]
        [Required(ErrorMessage = "El departamento No es opcional")]
        public string departamento { get; set; }
    }
}
