﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFactoryMethodDesignPattern.NotificationSystem
{
    public class SmsNotificationCreator : NotificationCreator
    {
        public override INotification CreateNotification()
        {
            return new SmsNotification();
        }
    }
}
