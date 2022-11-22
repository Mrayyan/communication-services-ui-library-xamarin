using System.Collections.Generic;
namespace CommunicationCallingXamarinSampleApp
{
    public interface IComposite
    {
        void joinCall(string threadID, string acsToken, string endPointUrl, string displayName, string identity);

    }
}
