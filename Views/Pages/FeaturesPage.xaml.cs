using Lumina.ViewModels.Pages;
using System.IO;
using Wpf.Ui.Controls;
using Lumina;
using static CommunityToolkit.Mvvm.ComponentModel.__Internals.__TaskExtensions.TaskAwaitableWithoutEndValidation;
using System.Windows.Controls;
using System.Windows.Documents;
using Microsoft.VisualStudio.Threading;
using System.Configuration;

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

            if (Settings1.Default.Status1 == true)
            {
                AutoCollectToggle.IsChecked = true;
            }
            else
            {
                AutoCollectToggle.IsChecked = false;
            }

            if (Settings1.Default.Status2 == true)
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
            Worker.Run();
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
            Settings1.Default.ison = true;
            Settings1.Default.Save();
            Settings1.Default.Reload();
        }
        private static void isonFalse()
        {
            Settings1.Default.ison = false;
            Settings1.Default.Save();
            Settings1.Default.Reload();
        }


        private static void Status1True()
        {
            Settings1.Default.Status1 = true;
            Settings1.Default.Save();
            Settings1.Default.Reload();
        }
        private static void Status1False()
        {
            Settings1.Default.Status1 = false;
            Settings1.Default.Save();
            Settings1.Default.Reload();
        }

        private static void Status2True()
        {
            Settings1.Default.Status2 = true;
            Settings1.Default.Save();
            Settings1.Default.Reload();
        }
        private static void Status2False()
        {
            Settings1.Default.Status2 = false;
            Settings1.Default.Save();
            Settings1.Default.Reload();
        }
    }
}
