using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class DeletedTransaction
    {
        public string TxnId { get; set; } = null!;
        public string? TxnDelType { get; set; }
        public string? RefNumber { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeDeleted { get; set; }
    }
}
