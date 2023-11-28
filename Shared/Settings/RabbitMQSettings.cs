using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Settings
{
    public static class RabbitMQSettings
    {
        public const string StateMachineQueue = $"state-machine-queue";

        public const string Stock_OrderCreatedEventQueue = $"stock-order-created-event-queue";

        public const string Order_OrderCompletedEventQueue = $"order-order-completed-event-queue";

        public const string Order_OrderFailedEventQueue = $"order-order-failed-event-queue";

        public const string Stock_RollbackMessageQueue = $"stock-rollback-message-queue";

        public const string Payment_StartedEventQueue = $"payment-started-event-queue";
    }
}
