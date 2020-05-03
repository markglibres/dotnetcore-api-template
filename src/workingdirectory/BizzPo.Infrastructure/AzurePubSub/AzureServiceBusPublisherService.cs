﻿using System;
using System.Threading;
using System.Threading.Tasks;
using BizzPo.Core.Application;

namespace BizzPo.Infrastructure.AzurePubSub
{
    //do your own implementation..
    //or you can inherit / user from
    //BizzPo.Core.Infrastructure.Messaging.AzureServiceBus.EventPublisherService
    public class AzureServiceBusPublisherService<T>
        : IIntegrationEventPublisherService<T>
        where T : IIntegrationEvent

    {
        public Task Publish(T @event, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}