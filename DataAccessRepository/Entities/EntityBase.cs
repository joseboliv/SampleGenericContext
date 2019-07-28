using System.ComponentModel.DataAnnotations;

namespace DataAccessRepository.Entities
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}