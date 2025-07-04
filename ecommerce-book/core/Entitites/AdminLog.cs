using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Entitites
{
    public class AdminLog
    {
        [Key]
        public int LogId { get; set; }

        public int AdminId { get; set; }

        public string Action { get; set; }

        [MaxLength(45)]
        public string IpAddress { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [ForeignKey("AdminId")]
        public User Admin { get; set; }
    }
}
