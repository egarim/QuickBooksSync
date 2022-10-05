using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class DeletedEntity
    {
        public string ListId { get; set; } = null!;
        public string? ListDelType { get; set; }
        public string? FullName { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeDeleted { get; set; }
    }
}
