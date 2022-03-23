using BookCatalogueService.Messages.Topics;

namespace BookCatalogueService.Services
{
    public interface IProducerScope
    {
      //  void Publish(MessageRequest<MessageEvent> messageRequest);
        void Complete();
    }
}