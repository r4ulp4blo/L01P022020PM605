﻿using System.ComponentModel.DataAnnotations;

namespace L01P022020PM605.Models
{
    public class materias
    {
        [Key]
        public int id { get; set; }
        public string materia { get; set; }
        public int unidades_valorativas { get; set; }
        public int estado { get; set; }
    }
}
