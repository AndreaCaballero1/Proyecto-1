using Proyecto_1.Models;
using Proyecto_1.PageModels;

namespace Proyecto_1.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}