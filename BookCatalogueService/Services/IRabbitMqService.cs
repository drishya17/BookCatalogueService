using BookCatalogueService.Messages.Topics;

namespace BookCatalogueService.Services
{
    public class IRabbitMqService
    {
        /// <summary>
        /// IRabbitMqDataService
        /// </summary>
        public interface IRabbitMqDataService
        {
            /// <summary>
            /// Publishes the sample message to xpo connect.
            /// </summary>
            /// <param name="message">The message.</param>
            void PublishDocumentDetailsToXpoConnect(MessageEvent message);

        }
    }
}
