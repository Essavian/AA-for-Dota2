using System;
using System.Linq;
using PushbulletSharp;
using PushbulletSharp.Models.Requests;
using PushbulletSharp.Models.Responses;

namespace AutoAccepter
{
    public static class NotificationsController
    {
        public enum NotifycationMessages
        {
            OK = 0,
            Has_no_device = 1,
            Error = 2
        }

        public static NotifycationMessages Notify(string token)
        {
            PushbulletClient client = new PushbulletClient(token);
            var devices = client.CurrentUsersDevices();
            var device = devices.Devices.Where(o => o.Active == true).FirstOrDefault();

            if (device != null)
            {
                PushNoteRequest reqeust = new PushNoteRequest()
                {
                    DeviceIden = device.Iden,
                    Title = "Auto Accepter for Dota 2",
                    Body = "YOUR GAME IS READY!!!"
                };

                PushResponse response = client.PushNote(reqeust, false);

                return NotifycationMessages.OK;
            }
            else
            {
                return NotifycationMessages.Has_no_device;
            }
        }

        public static bool CheckToken(string token)
        {
            try
            {
                PushbulletClient client = new PushbulletClient(token);
                var devices = client.CurrentUsersDevices();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
