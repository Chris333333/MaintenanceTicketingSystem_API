using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Data.Entities
{
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CommentId { get; set; }

        public string Content { get; set; } = null!;

        public required int TicketId { get; set; }

        public required int UserId { get; set; }
        [DefaultValue(typeof(DateTime), "getdate()")]
        public DateTime CreateDt { get; set; }

        public virtual Ticket Ticket { get; set; } = null!;

    }
}
