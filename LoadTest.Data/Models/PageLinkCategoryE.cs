using System.Collections.Generic;

namespace LoadTest.Data.Models
{
    public class PageLinkCategoryE
    {
        public PageLinkCategoryE()
        {
            PageLink = new HashSet<PageLinkE>();
        }

        public int PageLinkCategoryEId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int SortOrder { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<PageLinkE> PageLink { get; set; }
    }
}
