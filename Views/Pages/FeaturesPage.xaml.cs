using Lumina.ViewModels.Pages;
using System.IO;
using Wpf.Ui.Controls;
using Lumina;
using static CommunityToolkit.Mvvm.ComponentModel.__Internals.__TaskExtensions.TaskAwaitableWithoutEndValidation;
using System.Windows.Controls;

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
        }

        private void ToggleSwitch_Checked(object sender, RoutedEventArgs e)
        {
            string Status1File = File.ReadAllText(@"./Config/Status1.txt");

            if (Status1File.Contains("false", StringComparison.OrdinalIgnoreCase))
            {
                using (StreamWriter writer = new StreamWriter(@"./config/Status1.txt"))
                {
                    writer.WriteLine("true");
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(@"./config/Status1.txt"))
                {
                    writer.WriteLine("false");
                }
            }
        }
        private void ToggleSwitch_UnChecked(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Toggled Off");
            using (StreamWriter writer = new StreamWriter(@"./config/Status1.txt"))
            {
                writer.WriteLine("false");
            }
        }

        private void AutoCollectGlobal_Checked(object sender, RoutedEventArgs e)
        {
            string Status1File = File.ReadAllText(@"./Config/Status1.txt");

            if (Status1File.Contains("false", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("No Features Selected");
            }
            else if (Status1File.Contains("true", StringComparison.OrdinalIgnoreCase))
            {
                Worker.SomeMethod();
            }
        }
        private void AutoCollectGlobal_UnChecked(object sender, RoutedEventArgs e)
        {

        }
    }
}
