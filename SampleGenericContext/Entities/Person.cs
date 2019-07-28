using DataAccessRepository.Entities;
using System.Collections.Generic;

namespace SampleGenericContext.Entities
{
    public class Person : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<PersonAddress> PersonAddress { get; set; }
    }
}