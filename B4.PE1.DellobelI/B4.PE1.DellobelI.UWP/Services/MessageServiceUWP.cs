//ensures the PCL has access to this class. Must be defined outside of the namespace 
[assembly: Xamarin.Forms.Dependency(typeof(B4.PE1.DellobelI.UWP.Services.MessageServiceUWP))]

namespace B4.PE1.DellobelI.UWP.Services
{
    public class MessageServiceUWP : IMessageService
    {
        public string GetWelcomeMessage()
        {
            return "UWP!";
        }
    }
}
