using System.ComponentModel;

namespace Data.Entities
{
    public class Comment : BaseEntity
    {
        public string Content { get; set; } = null!;

        public required int TicketId { get; set; }

        public required int UserId { get; set; }
        [DefaultValue(typeof(DateTime), "getdate()")]
        public DateTime CreateDt { get; set; }

        public virtual Ticket Ticket { get; set; } = null!;

    }
}
