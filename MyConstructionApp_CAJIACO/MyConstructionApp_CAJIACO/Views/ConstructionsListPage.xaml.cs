using MyConstructionApp_CAJIACO.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyConstructionApp_CAJIACO.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConstructionsListPage : ContentPage
    {

        ConstructionViewModel constructionViewModel;
        public ConstructionsListPage()
        {
            InitializeComponent();

            BindingContext = constructionViewModel = new ConstructionViewModel();

            LoadConstructionList();

        }


        private async void LoadConstructionList()
        {
            LvList.ItemsSource = await constructionViewModel.GetConstructionsAsync(GlobalObjects.MyLocalUser.IDUsuario);
        }
    }
}