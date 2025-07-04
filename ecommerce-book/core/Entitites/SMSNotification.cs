using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Entitites
{
    public class SMSNotification
    {
        [Key]
        public int SmsId { get; set; }

        public int? UserId { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }

        public string Message { get; set; }

        public NotificationStatus Status { get; set; } = NotificationStatus.Sent;

        public DateTime SentAt { get; set; } = DateTime.UtcNow;

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
