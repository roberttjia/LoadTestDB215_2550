using System;
using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public class PageLinkE
    {
        public PageLinkE()
        {
            PageLinkAssign = new HashSet<PageLinkAssignE>();
        }

        public int PageLinkEId { get; set; }
        public int PageLinkCategoryEId { get; set; }
        public string PageName { get; set; } = string.Empty;
        public string PageUrl { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public int SortOrder { get; set; }
        public bool IsActive { get; set; }
        public DateTime InsertDate { get; set; }

        public virtual PageLinkCategoryE PageLinkCategory { get; set; } = null!;
        public virtual ICollection<PageLinkAssignE> PageLinkAssign { get; set; }
    }
}
