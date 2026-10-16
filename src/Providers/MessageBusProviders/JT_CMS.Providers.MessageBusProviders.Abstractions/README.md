# JT_CMS.Providers.MessageBusProviders.Abstractions

Contratos (abstrações) do provider de **barramento de mensagens**. Permite trocar a implementação concreta sem alterar o restante do sistema.

## Contrato

```csharp
public interface IMessagePublisher
{
    Task Publish<TPayload>(Message<TPayload> message, CancellationToken cancellationToken = default);
}
// Também: IMessageHandler e Message<TPayload>
```

## Como usar

Injete `IMessagePublisher` via injeção de dependência. A implementação padrão está em [JT_CMS.Providers.MessageBusProviders](../JT_CMS.Providers.MessageBusProviders/README.md).

## 🖼️ Imagens

> Coloque as imagens desta seção em [`docs/images/providers`](../../../../docs/images/providers/).

<!--
Exemplo de uso (descomente após adicionar a imagem):
![Descrição da imagem](../../../../docs/images/providers/nome-da-imagem.png)
-->
