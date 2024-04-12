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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Movement.AutoObb();
        }

        private void GlobalToggle_UnChecked(object sender, RoutedEventArgs e)
        {

        }
        private void GlobalToggle_Checked(object sender, RoutedEventArgs e)
        {

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
