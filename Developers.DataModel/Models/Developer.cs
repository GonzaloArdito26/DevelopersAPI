using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Developers.DataModel.Models
{
    [Table("developers")]
    public class Developer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public ICollection<Skill> Skills { get; set; }
    }
}