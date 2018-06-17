using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        public string Sex { get; set; }

        public virtual SchoolClass Class { get; set; }
    }
}