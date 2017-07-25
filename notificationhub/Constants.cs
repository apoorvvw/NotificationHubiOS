using System;
namespace notificationhub
{
    public class Constants
    {
        public Constants()
        {
        }
		// Azure app-specific connection string and hub path
		public const string ConnectionString = "Endpoint=sb://ns-notificationhubios.servicebus.windows.net/;SharedAccessKeyName=DefaultListenSharedAccessSignature;SharedAccessKey=immMA/de52Pbmo2hVy1x08pWnHd8dKUokMYXRHUx/FI=";
		public const string NotificationHubPath = "hub_notificationhubiOS";
    }
}
