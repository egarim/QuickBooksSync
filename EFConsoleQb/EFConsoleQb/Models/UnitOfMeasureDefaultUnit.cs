using System;
using System.Collections.Generic;

namespace EFConsoleQb.Models
{
    public partial class UnitOfMeasureDefaultUnit
    {
        public string Id { get; set; } = null!;
        public string? UnitOfMeasureSetId { get; set; }
        public string? Name { get; set; }
        public bool? IsActive { get; set; }
        public string? UnitOfMeasureType { get; set; }
        public string? BaseUnitName { get; set; }
        public string? BaseUnitAbbreviation { get; set; }
        public string? DefaultUnitUnitUsedFor { get; set; }
        public string? DefaultUnitUnit { get; set; }
        public string? EditSequence { get; set; }
        public DateTime? TimeCreated { get; set; }
        public DateTime? TimeModified { get; set; }

        public virtual UnitOfMeasure? UnitOfMeasureSet { get; set; }
    }
}
