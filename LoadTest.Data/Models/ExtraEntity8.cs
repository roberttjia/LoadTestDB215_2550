using System;

namespace LoadTest.Data.Models
{
    public class ExtraEntity8
    {
        public int ExtraEntity8Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Value { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}