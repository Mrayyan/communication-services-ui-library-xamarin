using System;
using System.Collections.Generic;
using System.Net;
using Android.Graphics;
using Android.OS;
using Android.Util;
using Com.Azure.Android.Communication.Common;
using Com.Azure.Android.Communication.UI.Chat;
using Com.Azure.Android.Communication.UI.Chat.Models;
using Java.Interop;
using Java.Util;

[assembly: Xamarin.Forms.Dependency(typeof(CommunicationCallingXamarinSampleApp.Droid.Composite))]
namespace CommunicationCallingXamarinSampleApp.Droid
{
    public class Composite : IComposite
    {
        public void joinCall(string threadID, string acsToken, string endPointUrl, string displayName, string identity) {
            CommunicationTokenCredential credentials = new CommunicationTokenCredential(acsToken);


            ChatComposite chatComposite = new ChatCompositeBuilder().Build();

            CommunicationTokenCredential communicationTokenCredential =
                    new CommunicationTokenCredential(acsToken);

            ChatCompositeJoinLocator locator =
                    new ChatCompositeJoinLocator(threadID, endPointUrl);
            ChatCompositeRemoteOptions remoteOptions =
                    new ChatCompositeRemoteOptions(locator, communicationTokenCredential, identity, displayName);

            chatComposite.Launch(MainActivity.Instance, remoteOptions, new ChatCompositeLocalOptions());

        }
       
    }

}
