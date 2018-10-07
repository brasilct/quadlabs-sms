using System.ComponentModel.DataAnnotations;

namespace SMSQL.Domain.Enums
{
    public enum EventName
    {
        BOOKINGCONFIRMATION,
        CLIENTREGISTRATION,
        PAYMENT,
        B2BREGISTRATION,
        TICKET,
        B2BTPIN,
        PaymentReminder,
        TripReminder,
        THANKS,
        DISPATCHED
    }
}
