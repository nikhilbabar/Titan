using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Titan.Domain.Relational
{
    [Table("UserType")]
    public class UserType
    {
        public UserType()
        {
            Users = new HashSet<User>();
        }

        [Key]
        public byte Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public byte Code { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}