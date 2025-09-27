using System;

namespace LoadTest.Data.Models
{
    public class ExtraEntity3
    {
        public int ExtraEntity3Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Value { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}