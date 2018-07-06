using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.Models.Entities;

namespace test.Services
{
    internal class Comparer : IEqualityComparer<Teacher>
    {
        public bool Equals(Teacher x, Teacher y)
        {
            return x.Id == y.Id;
        }

        public int GetHashCode(Teacher obj)
        {
            return obj.Surname.GetHashCode() ^ obj.Name.GetHashCode();
        }
    }
}
