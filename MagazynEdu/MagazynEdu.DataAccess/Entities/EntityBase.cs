using System.ComponentModel.DataAnnotations;

namespace MagazynEdu.DataAccess.Entities
{
    public abstract class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}