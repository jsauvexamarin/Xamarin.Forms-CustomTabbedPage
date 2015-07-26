using System;
using Xamarin.Forms;

namespace CustomTabBar
{
    public class TabView : ContentView
    {
        readonly int _Index;

        public TabView(TabContentItem item, int index)
        {
            if (index < 0)
            {
                throw new ArgumentException("index", "index property must be non-negative");
            }

            _Index = index;

            StackLayout stackLayout = new StackLayout();
            
            stackLayout.Children.Add(
                new Label()
                { 
                    Text = item.Title, 
                    VerticalOptions = new LayoutOptions(LayoutAlignment.Center, true),
                    HorizontalOptions = new LayoutOptions(LayoutAlignment.Center, true) 
                });
            
            if (!String.IsNullOrWhiteSpace(item.IconPath))
            {
                stackLayout.Children.Add(new Image() { Source = new FileImageSource() { File = item.IconPath } });
            }

            Content = stackLayout;
        }
    }
}

