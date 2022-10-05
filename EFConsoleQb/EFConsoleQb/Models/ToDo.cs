using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class ToDo
    {
        public string Id { get; set; } = null!;
        public string? Notes { get; set; }
        public bool? IsActive { get; set; }
        public string? Type { get; set; }
        public string? Priority { get; set; }
        public bool? IsDone { get; set; }
        public DateTime? ReminderDate { get; set; }
        public string? ReminderTime { get; set; }
        public string? EditSequence { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }
    }
}
