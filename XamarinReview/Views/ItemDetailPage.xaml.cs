using System.ComponentModel;
using Xamarin.Forms;
using XamarinReview.ViewModels;

namespace XamarinReview.Views
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