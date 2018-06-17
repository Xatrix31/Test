using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.Models.Interfaces;

namespace test.Services.Services
{
    public class TeachersService:ITeachersService
    {
        private readonly IRepository _repository;

        public TeachersService(IRepository repository)
        {
            _repository = repository;
        }


    }
}