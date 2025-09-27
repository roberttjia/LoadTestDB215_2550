using System;

namespace LoadTest.Data.Models
{
    public class ExtraEntity7
    {
        public int ExtraEntity7Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Value { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}