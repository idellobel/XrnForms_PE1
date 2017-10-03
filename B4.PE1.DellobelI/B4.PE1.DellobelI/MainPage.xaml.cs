using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace B4.PE1.DellobelI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var msgService = DependencyService.Get<IMessageService>();
            lblWelcome.Text = "Opdracht B4.PE1.DellobelI op " + msgService.GetWelcomeMessage();
        }

        private async void btnPictureGallery_Clicked(object sender, EventArgs e)
        {
            //navigate to Picture gallery
            await Navigation.PushAsync(new PictureGallery());
        }
    }
}
