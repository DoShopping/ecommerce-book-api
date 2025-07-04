using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Entitites
{
    public class EmailNotification
    {
        [Key]
        public int EmailId { get; set; }

        public int? UserId { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public NotificationStatus Status { get; set; } = NotificationStatus.Sent;

        public DateTime SentAt { get; set; } = DateTime.UtcNow;

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
