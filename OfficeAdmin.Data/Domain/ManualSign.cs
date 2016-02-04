﻿using System;
using System.ComponentModel.DataAnnotations;

namespace OfficeAdmin.Data.Domain
{
    public class ManualSign
    {
        [Key]
        public int ManualSignID { get; set; }
        public DateTime SignTime { get; set; }
        public string SignDesc { get; set; }
        public int SignTag { get; set; }
        public int UserID { get; set; }

        // Foreign keys
        public virtual UserInfo UserInfo { get; set; }
    }
}
