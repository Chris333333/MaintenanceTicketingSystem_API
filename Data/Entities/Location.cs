namespace Data.Entities
{
    public class Location : BaseEntity
    {
        public Location()
        {
            this.Layouts = new HashSet<Layout>();
        }

        public required string Name { get; set; } = null!;

        public required string Street { get; set; } = null!;

        public required string City { get; set; } = null!;

        public virtual ICollection<Layout> Layouts { get; set; } = new List<Layout>();

    }
}
