using System;
using System.Collections.Generic;

namespace CustomTabBar
{
    public class CustomTabbedContentViewModel
    {
        public List<TabContentItem> Items = new List<TabContentItem>()
        {
            new TabContentItem("One"),
            new TabContentItem("Two"),
            new TabContentItem("Three")
        };
    }
}

