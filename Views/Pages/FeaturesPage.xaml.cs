using Lumina.ViewModels.Pages;
using System.IO;
using Wpf.Ui.Controls;
using Lumina;
using static CommunityToolkit.Mvvm.ComponentModel.__Internals.__TaskExtensions.TaskAwaitableWithoutEndValidation;
using System.Windows.Controls;
using System.Windows.Documents;
using Microsoft.VisualStudio.Threading;

namespace Lumina.Views.Pages
{
    public partial class FeaturesPage : INavigableView<FeaturesViewModel>
    {
        public FeaturesViewModel ViewModel { get; }

        public FeaturesPage(FeaturesViewModel viewModel)
        {
            bool StatusAutoCollect = false;
            bool StatusAutoObby = false;
            ViewModel = viewModel;
            DataContext = this;

            string CheckPath2 = File.ReadAllText(@".\Config\Status3.txt");
            string CheckPath = File.ReadAllText(@".\Config\Status1.txt");

            InitializeComponent();

            if (CheckPath.Contains("false", StringComparison.OrdinalIgnoreCase))
            {
                StatusAutoCollect = false;
                AutoCollectToggle.IsChecked = false;
            }

            else if (CheckPath.Contains("true", StringComparison.OrdinalIgnoreCase))
            {
                StatusAutoCollect = true;
                AutoCollectToggle.IsChecked = true;
            }

            if (CheckPath2.Contains("false", StringComparison.OrdinalIgnoreCase))
            {
                StatusAutoCollect = false;
                ObbyToggle.IsChecked = false;
            }

            else if (CheckPath2.Contains("true", StringComparison.OrdinalIgnoreCase))
            {
                StatusAutoCollect = true;
                ObbyToggle.IsChecked = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Movement.AutoObb();
        }

        private void GlobalToggle_UnChecked(object sender, RoutedEventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(@"./config/ISON.txt"))
            {
                writer.WriteLine("false");
            }
        }
        private async void GlobalToggle_Checked(object sender, RoutedEventArgs e)
        {
            await TaskScheduler.Default;
            using (StreamWriter writer = new StreamWriter(@"./config/ISON.txt"))
            {
                writer.WriteLine("true");
            }
            Worker.Run();
        }

        private void AutoCollectToggle_Checked(object sender, RoutedEventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(@"./config/Status1.txt"))
            {
                writer.WriteLine("true");
            }
        }

        private void AutoCollectToggle_UnChecked(object sender, RoutedEventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(@"./config/Status1.txt"))
            {
                writer.WriteLine("false");
            }
        }

        private void ObbyToggle_Checked(object sender, RoutedEventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(@"./config/Status3.txt"))
            {
                writer.WriteLine("true");
            }
        }

        private void ObbyToggle_UnChecked(object sender, RoutedEventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(@"./config/Status3.txt"))
            {
                writer.WriteLine("false");
            }
        }
    }
}
