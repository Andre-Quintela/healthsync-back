using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace healthsync_back.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        [Column("id")] // Mapeia o nome da coluna no banco
        public int Id { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("born_date")]
        public DateTime BornDate { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("address")]
        public string Address { get; set; }

    }
}
