using BookCatalogueService.Messages.Topics;
using Common.Logging;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookCatalogueService.Services
{
    /// <summary>
    /// RabbitMqDataService
    /// </summary>
    public class RabbitMqServices : IRabbitMqService
    {
        /// <summary>
        /// IRMQConnectProducerScopeFactory
        /// </summary>
        //private readonly IProducerScopeFactory _rabbitMqProducerScopeFactory;
      

        /// <summary>
        /// RabbitMqDataService constructor
        /// </summary>
        /// <param name="rabbitMqProducerScopeFactory"></param>
        /// <param name="logger"></param>
        //public RabbitMqServices(IProducerScopeFactory rabbitMqProducerScopeFactory)
        //{
        //    _rabbitMqProducerScopeFactory = rabbitMqProducerScopeFactory;
        //}

        /// <summary>
        /// Publishes the sample message to xpo connect.
        /// </summary>
        /// <param name="message"></param>
        public void PublishDocumentDetailsToXpoConnect(MessageEvent message)
        {
            try
            {
                //using (var producerScope = _rabbitMqProducerScopeFactory.Get())
                //{
                //    producerScope.Publish(new MessageRequest<MessageEvent>(message));
                //    producerScope.Complete();
                //}
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}