using Lumina.ViewModels.Pages;
using System.IO;
using System.Net;
using System.Reflection.PortableExecutable;
using Wpf.Ui.Controls;

namespace Lumina.Views.Pages
{
    public partial class FullAutoPage : INavigableView<FullAutoViewModel>
    {
        public FullAutoViewModel ViewModel { get; }

        public FullAutoPage(FullAutoViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;


            InitializeComponent();
        }


        private void FullAutoToggle_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            }
            catch (Exception ex) { }
        }

        private void No_Click(object sender, RoutedEventArgs e) 
        {
            try
            {

            }
            catch (Exception ex) { }
        }
    }
}
