using LearnXamarin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace LearnXamarin.Views
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