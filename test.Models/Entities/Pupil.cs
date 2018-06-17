using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using test.Models.Enums;

namespace test.Models.Entities
{
    [Table("Pupils")]
    public class Pupil
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
        [EnumDataType(typeof(Sex))]
        public string Sex { get; set; }

        [ForeignKey("Class")]
        public long IdClass { get; set; }

        public virtual SchoolClass Class { get; set; }
    }
}