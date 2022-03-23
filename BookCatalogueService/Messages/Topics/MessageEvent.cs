using System;

namespace BookCatalogueService.Messages.Topics
{ /// <summary>
  /// Class DocumentMessageEvent.
  /// </summary>
    [Topic("GFF", "XpoConnect", "DocumentMessageEvent")]
    public class MessageEvent 
    {
        /// <summary>
        /// Gets or sets the entity code. = Event Queue Type
        /// </summary>
        /// <value>The entity code.</value>
        public string EntityCode { get; } = Guid.NewGuid().ToString();

        /// <summary>
        /// Gets or sets the Message
        /// </summary>
        /// <value>The Message.</value>
        public string Message { get; set; }
    }
}
