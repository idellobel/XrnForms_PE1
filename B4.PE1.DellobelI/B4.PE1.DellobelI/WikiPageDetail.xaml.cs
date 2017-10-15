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
    public partial class WikiPageDetail : ContentPage
    {
        

        public WikiPageDetail()
        {
            InitializeComponent();
            //Image embeddedImage = new Image { Aspect = Aspect.AspectFill };
            ////get the image by ResourceID
            //embeddedImage.Source = ImageSource.FromResource("B4.PE1.DellobelI.images.petacchi.jpg");
            //Image embeddedImage2 = new Image { Aspect = Aspect.AspectFill };
            ////get the image by ResourceID
            //embeddedImage2.Source = ImageSource.FromResource("B4.PE1.DellobelI.images.portalicon.png");
           
        }


    }
}