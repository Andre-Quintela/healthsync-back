using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace healthsync_back.Models
{
    [Table("Consultas")]
    public class Consulta
    {

        [Key]  // Marca a propriedade 'id' como chave primária
        [Column("id")]  // Mapeia o nome da coluna no banco
        public int Id { get; set; }

        [Required]  // Indica que a propriedade 'user_name' é obrigatória
        [StringLength(100)]  // Limita o comprimento da string a 100 caracteres
        [Column("user_name")]
        public string UserName { get; set; }

        [Required]  // Indica que a propriedade 'medico_nome' é obrigatória
        [StringLength(100)]  // Limita o comprimento da string a 100 caracteres
        [Column("medico_nome")]
        public string MedicoNome { get; set; }

        [Required]  // Indica que a propriedade 'data' é obrigatória
        [Column("data")]  // Mapeia o nome da coluna no banco
        public DateTime Data { get; set; }

        [Required]  // Indica que a propriedade 'hora' é obrigatória
        [StringLength(5)]  // Limita o comprimento da string a 5 caracteres (HH:mm)
        [Column("hora")]  // Mapeia o nome da coluna no banco
        public string Hora { get; set; }
    }
}
