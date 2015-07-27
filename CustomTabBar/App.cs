using System;

using Xamarin.Forms;
using System.Collections.Generic;

namespace CustomTabBar
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            var tabPage = new CustomTabbedPage();

            MainPage = tabPage;

            tabPage.BindingContext = new CustomTabbedContentViewModel();

            tabPage.SetBinding(CustomTabbedPage.ItemSourceProperty, new Binding("Items", BindingMode.OneWay));
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

