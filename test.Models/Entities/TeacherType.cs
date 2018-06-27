using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace test.Models.Entities
{
    [Table("TeacherTypes", Schema = "NSI")]
    public class TeacherType
    {
        public long Id { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}