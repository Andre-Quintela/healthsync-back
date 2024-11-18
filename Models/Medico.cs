using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace healthsync_back.Models
{
    [Table("Medicos")]
    public class Medico
    {
        [Key]
        [Column("id")] 
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }
    }
}
