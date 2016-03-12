using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace Kantor
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
            changeColorSeleced(sender as Button);
        }

        private void HisotoryButton_Click(object sender, RoutedEventArgs e)
        {
            clickOnnavigation(typeof(Pages.Archives), sender as Button);
        }

        private void CurrentButton_Click(object sender, RoutedEventArgs e)
        {
            clickOnnavigation(typeof(Pages.Current), sender as Button);
        }

        void clickOnnavigation(Type type, Button sp)
        {
            MySplitView.IsPaneOpen = false;
            changeColorSeleced(sp);
            Frame.Navigate(type);
        }

        void changeColorSeleced(Button btn)
        {
            btn.Foreground = new SolidColorBrush(Windows.UI.Colors.White);
        }


    }
}
