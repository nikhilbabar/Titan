using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Titan.Domain.Relational
{
    [Table("Search")]
    public class Search
    {
        public Search()
        {
            Users = new HashSet<User>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(5000)]
        public string Query { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}