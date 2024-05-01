using Lumina.ViewModels.Pages;
using System.Windows.Controls;
using Wpf.Ui.Controls;

namespace Lumina.Views.Pages
{
    public partial class FeaturesPage : INavigableView<FeaturesViewModel>
    {
        public FeaturesViewModel ViewModel { get; }

        public FeaturesPage(FeaturesViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();

            if (Settings.Default.FishingStatus == true)
            {
                FishingToggle.IsChecked = true;
            }
            else
            {
                FishingToggle.IsChecked = false;
            }

            TimeTextbox.Text = Settings.Default.SleepTime;
        }

        private void GlobalToggle_UnChecked(object sender, RoutedEventArgs e)
        {
            isonFalse();
        }
        private async void GlobalToggle_Checked(object sender, RoutedEventArgs e)
        {
            isonTrue();

            await Task.Run(() => Movement.Run());
        }

        private void FishingToggle_Checked(object sender, RoutedEventArgs e)
        {
            FishingStatusTrue();
        }

        private void FishingToggle_UnChecked(object sender, RoutedEventArgs e)
        {
            FishingStatusFalse();
        }

        // Config Saving
        private static void isonTrue()
        {
            Settings.Default.ison = true;
            Util.SaveConfig();
        }
        private static void isonFalse()
        {
            Settings.Default.ison = false;
            Settings.Default.Save();
            Util.SaveConfig();
        }


        private static void FishingStatusTrue()
        {
            Settings.Default.FishingStatus = true;
            Util.SaveConfig();
        }
        private static void FishingStatusFalse()
        {
            Settings.Default.FishingStatus = false;
            Util.SaveConfig();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string val = (TimeTextbox.Text != "") ? TimeTextbox.Text : "0";

            Settings.Default.SleepTime = val;
            Util.SaveConfig();
        }

        private void SleepTime_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
