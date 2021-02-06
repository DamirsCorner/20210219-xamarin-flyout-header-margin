using FlyoutHeaderMargin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace FlyoutHeaderMargin.Views
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