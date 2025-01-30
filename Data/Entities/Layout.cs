using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{

    public class Layout
    {
        public Layout()
        {
            this.Tickets = new HashSet<Ticket>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LayoutId { get; set; }

        public required string Name { get; set; } = null!;

        public required string Path { get; set; } = null!;

        public string? Description { get; set; }

        public int LocationId { get; set; }

        public virtual Location Location { get; set; } = null!;

        public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
