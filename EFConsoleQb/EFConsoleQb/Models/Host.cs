using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class Host
    {
        public string ProductName { get; set; } = null!;
        public string? MajorVersion { get; set; }
        public string? MinorVersion { get; set; }
        public string? Country { get; set; }
        public string? SupportedQbxmlversion { get; set; }
        public bool? IsAutomaticLogin { get; set; }
        public string? QbfileMode { get; set; }
    }
}
