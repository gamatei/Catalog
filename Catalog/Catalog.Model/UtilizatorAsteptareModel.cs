using System.ComponentModel.DataAnnotations;

namespace Catalog.Model
{
    public class UtilizatorAsteptareModel
    {
        public int ID { get; set; }
        [Required]
        public int IDUtilizator { get; set; }
        [Required]
        public string Hash { get; set; }
    }
}
