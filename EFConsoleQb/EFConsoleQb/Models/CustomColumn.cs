using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class CustomColumn
    {
        public string DataExtId { get; set; } = null!;
        public string? OwnerId { get; set; }
        public string? DataExtName { get; set; }
        public string? DataExtType { get; set; }
        public string? AssignToObject { get; set; }
        public bool? DataExtListRequire { get; set; }
        public bool? DataExtTxnRequire { get; set; }
        public string? DataExtFormatString { get; set; }
    }
}
