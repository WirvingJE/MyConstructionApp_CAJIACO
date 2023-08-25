using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyConstructionApp_CAJIACO.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();

            LoadUserName();
        }

        private void LoadUserName()
        {
            LblUserName.Text = GlobalObjects.MyLocalUser.Nombre.ToUpper();
        }

        private async void BtnUserManagment_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UserManagmentPage());
        }

        private async void BtnTypeConstrucion_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConstructionsListPage());

        }

        private async void BtnCategoryConstrucion_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CategoryConstrucion());
        }

        private async void BtnAdvanceConstrucion_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AdvanceConstrucion());

        }

        private async void BtnCreateTypeconstrucion_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateTypeconstrucion());
        }
    }
}