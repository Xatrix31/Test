using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test.Models.Entities
{
    [Table("Teachers")]
    public class Teacher
    {
        public long Id { get; set; }

        [Required]
        [DataType("varchar2")]
        [MaxLength]
        public string Name { get; set; }

        [Required]
        [DataType("varchar2")]
        [MaxLength]
        public string Surname { get; set; }

        [Required]
        [ForeignKey("TeacherType")]
        public long IdType { get; set; }

        public virtual TeacherType TeacherType { get; set; }
        public virtual ICollection<SchoolClass> Classes { get; set; }
    }
}