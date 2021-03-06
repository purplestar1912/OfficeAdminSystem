﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OfficeAdmin.Data.Domain
{
    public class MessageToUser
    {
        [Key]
        public int ID { get; set; }

        public bool IsRead { get; set; }

        [Index("IX_MessageID", IsUnique = false)]
        public int MessageID { get; set; }

        public string Receiver { get; set; }

        // Foreign keys
        public virtual Message Message { get; set; } 
    }
}
