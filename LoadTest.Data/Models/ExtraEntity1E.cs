using System;

namespace LoadTest.Data.Models
{
    public class ExtraEntity1E
    {
        public int ExtraEntity1EId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
