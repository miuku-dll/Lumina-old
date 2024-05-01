using FluentScheduler;
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

            GloveBox.Text = Settings.Default.GloveCount;

            if (Settings.Default.CollectStatus == true)
            {
                AutoCollectToggle.IsChecked = true;
            }
            else
            {
                AutoCollectToggle.IsChecked = false;
            }

            if (Settings.Default.ObbyStatus == true)
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

        }

        private void GlobalToggle_UnChecked(object sender, RoutedEventArgs e)
        {
            isonFalse();
        }
        private async void GlobalToggle_Checked(object sender, RoutedEventArgs e)
        {
            isonTrue();
            var timeout = Settings.Default.ison == false;

            await Task.Run(() => Movement.Run());
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
            Util.SaveConfig();
        }
        private static void isonFalse()
        {
            Settings.Default.ison = false;
            Settings.Default.Save();
            Util.SaveConfig();
        }


        private static void Status1True()
        {
            Settings.Default.CollectStatus = true;
            Util.SaveConfig();
        }
        private static void Status1False()
        {
            Settings.Default.CollectStatus = false;
            Util.SaveConfig();
        }

        private static void Status2True()
        {
            Settings.Default.ObbyStatus = true;
            Util.SaveConfig();
        }
        private static void Status2False()
        {
            Settings.Default.ObbyStatus = false;
            Util.SaveConfig();
        }

        private void ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            String Item = (this.GloveBox.SelectedItem as ComboBoxItem).Content.ToString();

            Settings.Default.GloveCount = Item;
            Util.SaveConfig();
        }

        private void StarChecker_Checked(object sender, RoutedEventArgs e)
        {
            JobManager.AddJob(() => Util.StarDetection(), (s) => s.ToRunEvery(8).Seconds());
        }

        private void StarChecker_UnChecked(object sender, RoutedEventArgs e)
        {
            JobManager.Stop();
        }
    }
}
