using MediatR;

namespace JT_CMS.Providers.MessageBusProviders;

public interface IMessageHandler<TPayload> : INotificationHandler<Message<TPayload>>
{
}
