using System;
using System.ComponentModel.DataAnnotations;

namespace Catalog.Model
{
    public class AbsentaModel
    {
        public int ID { get; set; }
        [Required]
        public int IDElev { get; set; }
        [Required]
        public int IDMaterieClasa { get; set; }
        [Required]
        public DateTime DataAbsenta { get; set; }

    }
}
