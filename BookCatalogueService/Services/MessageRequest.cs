using BookCatalogueService.Messages.Topics;

namespace BookCatalogueService.Services
{
    internal class MessageRequest<T>
    {
        private MessageEvent message;

        public MessageRequest(MessageEvent message)
        {
            this.message = message;
        }
    }
}