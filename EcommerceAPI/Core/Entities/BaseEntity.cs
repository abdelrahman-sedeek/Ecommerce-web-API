using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EcommerceAPI.Core.Entities
{
    public class BaseEntity
    {
        [Key]

        public int Id { get; set; }
    }
}
