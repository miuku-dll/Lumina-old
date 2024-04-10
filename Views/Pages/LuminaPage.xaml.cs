using Lumina.ViewModels.Pages;
using System.IO;
using System.Net;
using System.Reflection.PortableExecutable;
using Wpf.Ui.Controls;

namespace Lumina.Views.Pages
{
    public partial class LuminaPage : INavigableView<LuminaViewModel>
    {
        public LuminaViewModel ViewModel { get; }

        public LuminaPage(LuminaViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;


            InitializeComponent();
        }


    }
}
