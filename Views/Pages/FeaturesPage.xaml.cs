using Lumina.ViewModels.Pages;
using Wpf.Ui.Controls;
using Lumina.Workers;

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

            if (Settings.Default.Status1 == true)
            {
                AutoCollectToggle.IsChecked = true;
            }
            else
            {
                AutoCollectToggle.IsChecked = false;
            }

            if (Settings.Default.Status2 == true)
            {
                ObbyToggle.IsChecked = true;
            }
            else
            {
                ObbyToggle.IsChecked = false;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Movement.AutoObb();
        }

        private void GlobalToggle_UnChecked(object sender, RoutedEventArgs e)
        {
            isonFalse();
        }
        private async void GlobalToggle_Checked(object sender, RoutedEventArgs e)
        {
            isonTrue();
            Task.Factory.StartNew(() => Worker.Run());
        }

        private void AutoCollectToggle_Checked(object sender, RoutedEventArgs e)
        {
            Status1True();
        }

        private void AutoCollectToggle_UnChecked(object sender, RoutedEventArgs e)
        {
            Status1False();
        }

        private void ObbyToggle_Checked(object sender, RoutedEventArgs e)
        {
            Status2True();
        }

        private void ObbyToggle_UnChecked(object sender, RoutedEventArgs e)
        {
            Status2False();
        }

        // Config Saving
        private static void isonTrue()
        {
            Settings.Default.ison = true;
            Settings.Default.Save();
            Settings.Default.Reload();
        }
        private static void isonFalse()
        {
            Settings.Default.ison = false;
            Settings.Default.Save();
            Settings.Default.Reload();
        }


        private static void Status1True()
        {
            Settings.Default.Status1 = true;
            Settings.Default.Save();
            Settings.Default.Reload();
        }
        private static void Status1False()
        {
            Settings.Default.Status1 = false;
            Settings.Default.Save();
            Settings.Default.Reload();
        }

        private static void Status2True()
        {
            Settings.Default.Status2 = true;
            Settings.Default.Save();
            Settings.Default.Reload();
        }
        private static void Status2False()
        {
            Settings.Default.Status2 = false;
            Settings.Default.Save();
            Settings.Default.Reload();
        }
    }
}
