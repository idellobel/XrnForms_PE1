
//ensures the PCL has access to this class. Must be defined outside of the namespace 
[assembly: Xamarin.Forms.Dependency(typeof(B4.PE1.DellobelI.iOS.Services.MessageServiceIOs))]

namespace B4.PE1.DellobelI.iOS.Services
{
    public class MessageServiceIOs : IMessageService
    {
        public string GetWelcomeMessage()
        {
            return "IOS!";
        }
    }
}