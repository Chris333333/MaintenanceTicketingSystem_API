using System.ComponentModel;

namespace Data.Entities
{
    public class Ticket : BaseEntity
    {
        public Ticket()
        {
            this.Comments = new HashSet<Comment>();
        }

        public required string Titile { get; set; } = null!;
        [DefaultValue(typeof(DateTime), "getdate()")]
        public DateTime CreateDt { get; set; } = DateTime.Now;
        [DefaultValue(false)]
        public bool IsCompleted { get; set; } = false;

        public DateTime? CompletedDt { get; set; } = null;

        public int? LayoutId { get; set; }

        public virtual Layout? Layout { get; set; }

        public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

        
    }
}
