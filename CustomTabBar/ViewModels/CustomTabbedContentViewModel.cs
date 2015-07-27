﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CustomTabBar
{
    public class CustomTabbedContentViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        List<TabContentItem> items;
        public List<TabContentItem> Items
        {
            get { return items; }
            set
            {
                items = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Items"));
            }
        }

        TabBarPosition tabBarPosition;
        public TabBarPosition TabBarPosition
        {
            get { return tabBarPosition; }
            set
            {
                tabBarPosition = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("TabBarPosition"));
            }
        }

        public CustomTabbedContentViewModel()
        {
            Items = new List<TabContentItem>
            {
                new TabContentItem("One"),
                new TabContentItem("Two"),
                new TabContentItem("Three")
            };

            TabBarPosition = TabBarPosition.Bottom;
        }

    }
}

