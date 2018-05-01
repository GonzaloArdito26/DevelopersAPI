using System.Collections.Generic;

namespace Developers.Model.Models.Developers
{
    public class Developer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public IEnumerable<Skill> Skills { get; set; }
    }
}