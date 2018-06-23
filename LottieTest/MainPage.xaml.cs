// Copyright(c) Microsoft Corporation.All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace LottieTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            var temp = Player.Source;
        }

        void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            var item = sender.MenuItems.OfType<NavigationViewItem>().First(x => (string)x.Content == (string)args.InvokedItem);
            switch (item.Tag)
            {
                case "AuditCorpus":
                    ContentFrame.Navigate(typeof(AuditCorpus));
                    break;
                case "ScrapeLottieFiles":
                    ContentFrame.Navigate(typeof(LottieFilesScraper));
                    break;
                case "MyComposition":
                    ContentFrame.Navigate(typeof(MyComposition));
                    break;
                case "RewardsApp":
                    ContentFrame.Navigate(typeof(RewardsApp));
                    break;
                case "LargeComposition":
                    ContentFrame.Navigate(typeof(LargeComposition));
                    break;
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}
