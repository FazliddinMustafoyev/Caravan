﻿using Caravan.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caravan.Domain.Entities
{
    public class Truck : Auditable
    {
        public string Name { get; set; } = string.Empty;

        public string? ImagePath { get; set; }

        public double? MaxLoad { get; set; }

        public bool IsEmpty { get; set; } = true;

        public string? Description { get; set; }

        public string TruckNumber { get; set; } = string.Empty;

        public long UserId { get; set; }
        public virtual User Users { get; set; } = default!;

        public long LocationId { get; set; }
        public virtual Location TruckLocation { get; set; } = default!;
    }
}
