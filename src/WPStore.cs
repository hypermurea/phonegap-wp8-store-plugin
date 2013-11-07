using System.Runtime.Serialization;
using WPCordovaClassLib.Cordova;
using WPCordovaClassLib.Cordova.Commands;
using WPCordovaClassLib.Cordova.JSON;
using Microsoft.Phone.Shell;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Phone.Controls;
using System.Windows;
using Microsoft.Phone.Tasks;
using Microsoft.Phone.Marketplace;

namespace WPCordovaClassLib.Cordova.Commands
{
    public class WPStore : BaseCommand
    {
    
        public void review(string options)
        {
            (new MarketplaceReviewTask()).Show();
            DispatchCommandResult();
        }

        public void openStoreToBuyApp(string options) {
            (new MarketplaceDetailTask()).Show();
            DispatchCommandResult();
        }

        public void isTrial(string options) {
            bool isTrial;
#if DEBUG
            isTrial = true; // change this enable debugging in non-trial mode
#else
            var licenseInfo = new LicenseInformation();
            isTrial = licenseInfo.IsTrial();           
#endif
            DispatchCommandResult(new PluginResult(PluginResult.Status.OK, "{\"trial\": " + isTrial.ToString().ToLower() + "}"));
        }
   
    }
}