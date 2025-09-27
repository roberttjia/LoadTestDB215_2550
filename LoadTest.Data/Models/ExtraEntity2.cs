using System;

namespace LoadTest.Data.Models
{
    public class ExtraEntity2
    {
        public int ExtraEntity2Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Value { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}