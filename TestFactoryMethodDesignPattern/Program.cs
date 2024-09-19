using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFactoryMethodDesignPattern.NotificationSystem;

namespace TestFactoryMethodDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotificationCreator emailCreator = new EmailNotificationCreator();
            emailCreator.Notify("Email message content.");

            NotificationCreator smsCreator = new SmsNotificationCreator();
            smsCreator.Notify("SMS message content.");

            NotificationCreator pushCreator = new PushNotificationCreator();
            pushCreator.Notify("Push message content.");
        }
    }
}
