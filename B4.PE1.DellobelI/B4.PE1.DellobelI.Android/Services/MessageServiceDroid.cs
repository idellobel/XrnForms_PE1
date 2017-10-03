
//ensures the PCL has access to this class. Must be defined outside of the namespace 
[assembly: Xamarin.Forms.Dependency(typeof(B4.PE1.DellobelI.Droid.Services.MessageServiceDroid))]

namespace B4.PE1.DellobelI.Droid.Services
{
    public class MessageServiceDroid : IMessageService
    {
        public string GetWelcomeMessage()
        {
            return "Android!";
        }
    }
}