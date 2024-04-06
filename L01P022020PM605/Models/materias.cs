using System.ComponentModel.DataAnnotations;

namespace L01P022020PM605.Models
{
    public class materias
    {
        [Key]
        [Display(Name = "Id de materia")]
        public int id { get; set; }
        [Display(Name = "Materia")]
        [Required(ErrorMessage = "La materia No es opcional")]
        public string materia { get; set; }
        [Display(Name = "Unidades valorativas")]
        [Required(ErrorMessage = "Las unidades valorativas No son opcionales")]
        public int unidades_valorativas { get; set; }
        [Display(Name = "Estado")]
        [Required(ErrorMessage = "El estado No es opcional")]
        public string estado { get; set; }
    }
}
