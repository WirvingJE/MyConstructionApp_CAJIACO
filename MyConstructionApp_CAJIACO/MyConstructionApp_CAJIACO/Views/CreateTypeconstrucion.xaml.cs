using MyConstructionApp_CAJIACO.Models;
using MyConstructionApp_CAJIACO.ViewModels;
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
    public partial class CreateTypeconstrucion : ContentPage
    {
        UserViewModel viewModel;
        public CreateTypeconstrucion()
        {
            InitializeComponent();
        }


        private void BtnAdd_Clicked(object sender, EventArgs e)
        {
        }

    }

}