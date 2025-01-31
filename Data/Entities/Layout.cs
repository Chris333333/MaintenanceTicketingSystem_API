namespace Data.Entities
{

    public class Layout : BaseEntity
    {
        public Layout()
        {
            this.Tickets = new HashSet<Ticket>();
        }

        public required string Name { get; set; } = null!;

        public required string Path { get; set; } = null!;

        public string? Description { get; set; }

        public int LocationId { get; set; }

        public virtual Location Location { get; set; } = null!;

        public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
