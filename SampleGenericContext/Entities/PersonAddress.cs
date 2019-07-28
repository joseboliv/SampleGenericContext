using DataAccessRepository.Entities;

namespace SampleGenericContext.Entities
{
    public class PersonAddress : EntityBase
    {
        public int PersonId { get; set; }
        public string Address { get; set; }
    }
}