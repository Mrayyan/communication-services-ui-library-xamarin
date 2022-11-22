using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Xamarin.Essentials;
using Xamarin.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CommunicationCallingXamarinSampleApp
{
    public partial class JoinCallPage : ContentPage
    {
        IComposite callComposite = DependencyService.Get<IComposite>();
      

        public JoinCallPage()
        {
            InitializeComponent();

        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tokenEntry.Text) && !String.IsNullOrEmpty(chatThreadidOrMeetingLinkEntry.Text))
            {
                callComposite.joinCall(chatThreadidOrMeetingLinkEntry.Text, tokenEntry.Text, endpointUrlEntry.Text, nameEntry.Text, identityEntry.Text);

            }
        }

    }
}
