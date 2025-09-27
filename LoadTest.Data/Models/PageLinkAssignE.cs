using System;

namespace LoadTest.Data.Models
{
    public class PageLinkAssignE
    {
        public int PageLinkAssignEId { get; set; }
        public int PageLinkEId { get; set; }
        public string UserId { get; set; } = string.Empty;
        public bool CanView { get; set; }
        public DateTime InsertDate { get; set; }

        public virtual PageLinkE PageLink { get; set; } = null!;
    }
}
