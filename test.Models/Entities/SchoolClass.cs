using System.Collections.Generic;

namespace test.Models.Entities
{
    public class SchoolClass
    {
        public long Id { get; set; }
        public string ClassName { get; set; }

        public virtual ICollection<Pupil> Pupils { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}