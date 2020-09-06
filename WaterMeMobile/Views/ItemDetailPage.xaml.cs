using System.ComponentModel;
using Xamarin.Forms;
using WaterMeMobile.ViewModels;

namespace WaterMeMobile.Views
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