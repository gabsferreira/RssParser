using System;

namespace rss_parser
{
    public class Item
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Link { get; set; }
        public DateTime PublishDate { get; set; }
    }
}