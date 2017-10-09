using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace B4.PE1.DellobelI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PictureGallery : ContentPage
    {
        public PictureGallery()
        {
            InitializeComponent();
        }

        private async void btnGoBack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();

        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            GestureState gestureState;
            Image imageSender = (Image) sender;
           
            await Navigation.PushAsync(new PhotoPage(imageSender));
            gestureState = GestureState.Ended;

        }


    }
    public class PhotoPage : ContentPage
    {

        public PhotoPage(Image gallery)
        {
            var GetImage = gallery.Source.ToString();

            Image Large = new Image();
            Large.Source = GetImage.Substring(6);

            Button btnBackGallery = new Button
            {
                Text = "Back to Picture Gallery",
                Style = (Style)Application.Current.Resources["CancelButtonStyle"],
                Margin = new Thickness(5)
            };

            btnBackGallery.Clicked += BtnClose_Clicked;

            Style = (Style)Application.Current.Resources["ContentPageStyle"];
            Title = "Foto Large";
            Content = new ScrollView()
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,

                Content = new StackLayout()
                {

                   
                    Children = {
                                Large,
                                btnBackGallery
                                },

                }

            };
        }

        
        private async void BtnClose_Clicked(object sender, EventArgs e)
        {
           await Navigation.PopAsync();
        }



    }
   
}

    
