using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class Location
    {
        public Location()
        {
            this.Layouts = new HashSet<Layout>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LocationId { get; set; }

        public required string Name { get; set; } = null!;

        public required string Street { get; set; } = null!;

        public required string City { get; set; } = null!;

        public virtual ICollection<Layout> Layouts { get; set; } = new List<Layout>();

    }
}
