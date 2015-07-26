using System;

namespace CustomTabBar
{
    public class TabContentItem
    {
        public string Title { get; set; }

        public string IconPath { get; set; }

        public string Description { get; set; }

        public TabContentItem(string title, string iconPath = null)
        {
            Title = title;
            IconPath = iconPath;
            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras consequat, diam at aliquam consectetur, nunc justo rutrum augue, ac auctor enim arcu sit amet odio. Nunc vitae interdum turpis, consequat semper mi. Ut fermentum massa sapien, quis sodales augue feugiat et. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Etiam mollis facilisis ligula, ut sodales dolor scelerisque ut. Nullam facilisis quam eu rhoncus ultricies. Nunc ut tellus ut mi aliquet ultrices. Quisque laoreet est dolor, at dictum urna ultrices quis. Maecenas id commodo ex, ac pharetra odio. Morbi fringilla sollicitudin neque non congue. Curabitur gravida, velit id suscipit maximus, risus ipsum imperdiet tellus, at mollis est odio non leo. Maecenas ac egestas libero. Mauris non metus felis. In posuere ac enim euismod elementum. Duis mollis nunc nec ligula egestas dignissim. Sed nec placerat turpis.";
        }
    }
}

