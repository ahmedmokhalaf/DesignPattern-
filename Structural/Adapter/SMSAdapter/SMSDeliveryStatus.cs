using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Adapter.SMSAdapter
{
    public static class SMSDeliveryStatus
    {
        public enum SMSDeliveryStatusEnum
        {
         PENDING,
         SENT ,
         DELIVERED ,
         FAILED 
        }
    }
}
