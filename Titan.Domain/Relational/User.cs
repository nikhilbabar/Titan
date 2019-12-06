using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Titan.Domain.Relational
{
    [Table("User")]
    public class User
    {
        public User()
        {
            Searches = new HashSet<Search>();
        }
        
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "nvarchar(50)")]
        public string FirstName { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "nvarchar(50)")]
        public string LastName { get; set; }

        [Column("UserTypeId")]
        public int? TypeId { get; set; }

        [ForeignKey("TypeId")]
        public virtual UserType Type { get; set; }

        public virtual ICollection<Search> Searches { get; set; }
    }
}
