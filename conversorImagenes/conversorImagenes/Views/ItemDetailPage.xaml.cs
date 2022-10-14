using conversorImagenes.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace conversorImagenes.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}