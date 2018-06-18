﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace test.Models.Entities
{
    public class SchoolClass
    {
        public long Id { get; set; }

        [Required]
        [DataType("varchar2")]
        [MaxLength]
        public string ClassName { get; set; }

        public virtual ICollection<Pupil> Pupils { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}