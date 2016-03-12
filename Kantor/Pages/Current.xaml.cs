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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Kantor.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Current : Page
    {
        public Current()
        {
            this.InitializeComponent();
        }
        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = true;
            Button b = (Button)sender;
            b.Foreground = new SolidColorBrush(Windows.UI.Colors.White);
        }
        private void btnShowPane_click1(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = false;
            Button b = (Button)sender;
            b.Foreground = new SolidColorBrush(Windows.UI.Colors.White);
            this.Frame.Navigate(typeof(Pages.Current));
        }

        private void btnShowPane_click2(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = false;
            Button b = (Button)sender;
            b.Foreground = new SolidColorBrush(Windows.UI.Colors.White);
            this.Frame.Navigate(typeof(Pages.Archives));
        }
    }
}
