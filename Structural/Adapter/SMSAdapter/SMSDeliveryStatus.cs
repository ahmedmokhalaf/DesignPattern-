namespace DesignPattern.Structural.Adapter.SMSAdapter
{
    public static class SMSDeliveryStatus
    {
        public enum SMSDeliveryStatusEnum
        {
            PENDING,
            SENT,
            DELIVERED,
            FAILED
        }
    }
}
