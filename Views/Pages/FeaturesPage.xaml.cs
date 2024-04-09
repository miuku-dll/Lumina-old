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

            try
            {
                string Status1File = File.ReadAllText(@"./Config/Status1.txt");

                if (Status1File.Contains("false", StringComparison.OrdinalIgnoreCase))
                {
                    AutoCollectBtn.Content = "Off";
                }
                else if (Status1File.Contains("true", StringComparison.OrdinalIgnoreCase))
                {
                    AutoCollectBtn.Content = "On";
                }
                
            }
            catch { }



            InitializeComponent();
        }

        private void GlobalToggle_Click(object sender, RoutedEventArgs e)
        {
            bool on = false;

            if (on == false)
            {
                Worker.Starting();
                on = true;
            }
            else if (on == true)
            {
                return;
            }

           
        }

        private void AutoCollect_Click(object sender, RoutedEventArgs e)
        {
            string Status1File = File.ReadAllText(@"./Config/Status1.txt");

            if (Status1File.Contains("false", StringComparison.OrdinalIgnoreCase))
            {
                using (StreamWriter writer = new StreamWriter(@"./config/Status1.txt"))
                {
                    writer.WriteLine("true");
                    AutoCollectBtn.Content = writer.ToString();
                    AutoCollectBtn.Content = "On";
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(@"./config/Status1.txt"))
                {
                        writer.WriteLine("false");
                    AutoCollectBtn.Content = "Off";
                }
            }
        }
    }
}
