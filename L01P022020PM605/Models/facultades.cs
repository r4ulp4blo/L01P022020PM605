using System.ComponentModel.DataAnnotations;

namespace L01P022020PM605.Models
{
    public class facultades
    {
        [Key]

        [Display(Name = "id de facultad")]
        public int id { get; set; }
        [Display(Name = "Facultad")]
        [Required(ErrorMessage = "La facultad No es opcional")]
        public string facultad { get; set; }
    }
}
