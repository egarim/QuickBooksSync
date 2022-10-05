using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class CustomerNote
    {
        public string Id { get; set; } = null!;
        public string? CustomerId { get; set; }
        public string? Name { get; set; }
        public string? FullName { get; set; }
        public string? NoteId { get; set; }
        public string? Date { get; set; }
        public string? Note { get; set; }
        public string? EditSequence { get; set; }
        public DateTime? TimeModified { get; set; }
        public DateTime? TimeCreated { get; set; }

        public virtual Customer? Customer { get; set; }
    }
}
